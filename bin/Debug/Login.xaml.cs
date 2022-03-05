using System;
using System.Windows;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace Wpf_Zadaca_3
{

    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text != "" && sifra.Password != "")
            {
                try
                {

                    MySqlConnection konekcija = new MySqlConnection("Server = localhost; Database = tmp; Uid = root; Pwd = ;");
                    konekcija.Open();
                    MySqlCommand upit = new MySqlCommand("SELECT * FROM korisnici WHERE username=@ime AND password=PASSWORD(@sifra)", konekcija);
                    upit.Parameters.AddWithValue("@ime", txtUsername.Text);
                    upit.Parameters.AddWithValue("@sifra", sifra.Password);
                    int id=0;
                    MySqlDataReader reader = upit.ExecuteReader();
                    if (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id"]);
                        Properties.Settings.Default.ime = reader["ime"].ToString();
                        Properties.Settings.Default.prezime = reader["prezime"].ToString();
                        reader.Close();
                        Properties.Settings.Default.username = txtUsername.Text;
                        Properties.Settings.Default.password = sifra.Password;
                        Properties.Settings.Default.id = id;                       
                        MainWindow korpa = new MainWindow();
                        konekcija.Close();
                        this.Close();
                        korpa.Show();
                    }
                    else
                    {
                        MessageBox.Show("Pogrešni podaci!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtUsername.Text = "";
                        sifra.Password = "";
                    }
                    



                }
                catch
                {

                    MessageBox.Show("Pogrešni podaci!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtUsername.Text = "";
                    sifra.Password = "";
                }
            }

            else MessageBox.Show("Unesite podatke!","Greška!",MessageBoxButton.OK,MessageBoxImage.Error);
            
          
        }
    }
}

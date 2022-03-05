using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MySql.Data.MySqlClient;

namespace Wpf_Zadaca_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection konekcija = null;
        public MainWindow()
        {

            InitializeComponent();
            try
            {
                lbl_naslov.Content = "Korpa za kupovinu: " + Properties.Settings.Default.ime + " " + Properties.Settings.Default.prezime;
                konekcija = new MySqlConnection("Server = localhost; Database = tmp; Uid = root; Pwd = ;");
                konekcija.Open();
                MySqlCommand upit = new MySqlCommand("SELECT * FROM artikli WHERE id_korisnika=@id", konekcija);
                upit.Parameters.AddWithValue("@id", Properties.Settings.Default.id);
                MySqlDataReader reader = upit.ExecuteReader();
                while (reader.Read())
                {

                    ArtikalControl artikal = new ArtikalControl();
                    artikal.pocetna_kolicina = Convert.ToInt32(reader["kolicina"]);
                    artikal.jedinicna_cijena = (Convert.ToDecimal(reader["jedinicna_cijena"]));
                    artikal.id_artikla = Convert.ToInt32(reader["id"]);
                    artikal.lbl_naziv.Content = reader["naziv"].ToString();
                    artikal.lbl_cijena.Content = "";
                    artikal.tb_opis.Text = reader["opis"].ToString();
                    artikal.txtbox_kolicina.Text = reader["kolicina"].ToString();
                    artikal.lbl_cijena.Content = String.Format("{0:0.00}", (artikal.jedinicna_cijena * (Convert.ToDecimal(artikal.txtbox_kolicina.Text)))) + " KM";
                    if (reader["slika"].ToString() != "")
                    {
                        artikal.slika.Source = new ImageSourceConverter().ConvertFromString(@"slike\" + reader["slika"].ToString()) as ImageSource;
                    }
                    Properties.Settings.Default.ukupno += (Convert.ToDecimal(reader["jedinicna_cijena"])) * (Convert.ToDecimal(artikal.txtbox_kolicina.Text));

                    sp_artikli.Children.Add(artikal);
                }
                reader.Close();
                lbl_ukupno.Content = String.Format("{0:0.00}", Properties.Settings.Default.ukupno) + " KM";
                konekcija.Close();

            }
            catch
            {

                MessageBox.Show("Nije moguće pristupiti bazi!", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void zavrsi_Click(object sender, RoutedEventArgs e)
        {
            konekcija.Close();
            Application.Current.Shutdown();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            konekcija.Close();
        }


        private void dodaj_artikal()
        {
            ArtikalControl novi_artikal = new ArtikalControl();

        }
    }
}

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MySql.Data.MySqlClient;

namespace Wpf_Zadaca_3
{
    /// <summary>
    /// Interaction logic for ArtikalControl.xaml
    /// </summary>
    public partial class ArtikalControl : UserControl

    {
        MySqlConnection konekcija = new MySqlConnection("Server = localhost; Database = tmp; Uid = root; Pwd = ;");

        public int pocetna_kolicina = 0;
        public decimal jedinicna_cijena = 0;
        public int id_artikla = 0;






        public ArtikalControl()
        {
           // DataContext = this;
            konekcija.Open();
            InitializeComponent();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {

        }



        private void btn_smanji_Click(object sender, RoutedEventArgs e)
        {

            int kolicina = (Convert.ToInt32(txtbox_kolicina.Text));
            if (kolicina > 1)
            {
                kolicina--;
                txtbox_kolicina.Text = kolicina.ToString();
                if (kolicina < pocetna_kolicina)
                {
                    txtbox_kolicina.Background = Brushes.OrangeRed;
                }
                else if (kolicina > pocetna_kolicina)
                {
                    txtbox_kolicina.Background = Brushes.LightSeaGreen;
                }
                else txtbox_kolicina.Background = Brushes.White;
                lbl_cijena.Content = String.Format("{0:0.00}", (jedinicna_cijena * (Convert.ToDecimal(txtbox_kolicina.Text)))) + " KM";

                Properties.Settings.Default.ukupno -= jedinicna_cijena;
                Properties.Settings.Default.ukupno_labela = String.Format("{0:0.00}", Properties.Settings.Default.ukupno) + " KM";
                promjena();
            }


        }

        private void btn_povecaj_Click(object sender, RoutedEventArgs e)
        {
            int kolicina = (Convert.ToInt32(txtbox_kolicina.Text));
            kolicina++;
            txtbox_kolicina.Text = kolicina.ToString();
            if (kolicina < pocetna_kolicina)
            {
                txtbox_kolicina.Background = Brushes.OrangeRed;
            }
            else if (kolicina > pocetna_kolicina)
            {
                txtbox_kolicina.Background = Brushes.LightSeaGreen;
            }
            else txtbox_kolicina.Background = Brushes.White;
            lbl_cijena.Content = String.Format("{0:0.00}", (jedinicna_cijena * (Convert.ToDecimal(txtbox_kolicina.Text)))) + " KM";

            Properties.Settings.Default.ukupno += jedinicna_cijena;
            Properties.Settings.Default.ukupno_labela = String.Format("{0:0.00}", Properties.Settings.Default.ukupno) + " KM";

            promjena();

        }

        private void promjena()
        {

            string sql = "UPDATE artikli SET kolicina = " + Convert.ToInt32(txtbox_kolicina.Text) + " WHERE artikli.id = " + id_artikla;
            MySqlCommand upit = new MySqlCommand(sql, konekcija);
            upit.ExecuteNonQuery();



        }
        private void obrisi()
        {

            Properties.Settings.Default.ukupno -= Convert.ToDecimal(jedinicna_cijena * (Convert.ToDecimal(txtbox_kolicina.Text)));
            Properties.Settings.Default.ukupno_labela = String.Format("{0:0.00}", Properties.Settings.Default.ukupno) + " KM";
            string sql = "DELETE FROM artikli WHERE artikli.id = " + id_artikla;
            MySqlCommand upit = new MySqlCommand(sql, konekcija);
            upit.ExecuteNonQuery();
            konekcija.Close();

        }

        private void lbl_obrisi_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            obrisi();
            ((Panel)this.Parent).Children.Remove(this);
        }


    }
}

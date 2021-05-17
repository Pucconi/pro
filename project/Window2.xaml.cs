using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace project
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }



        private void butt1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            webBrowser1.Visibility = Visibility.Visible;
            // string Kraj = LAB1.Text;
            string Miasto = LAB1.Text;
            // string Hotel = LAB1.Text;
            // string Zabytek = LAB1.Text;
            try
            {
                StringBuilder adres = new StringBuilder();
                adres.Append("https://www.bing.com/maps?q=");
                // if (Kraj != string.Empty)
                // {
                //     adres.Append(Kraj + "," + "+");
                //  }
                if (Miasto != string.Empty)
                {
                    adres.Append(Miasto + "," + "+");
                }
                // if (Hotel != string.Empty)
                // {
                //     adres.Append(Hotel + "," + "+");
                // }
                // if (Zabytek != string.Empty)
                // {
                //     adres.Append(Zabytek + "," + "+");
                // }
                webBrowser1.Navigate(adres.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            trya.Visibility = Visibility.Visible;
        }

        

        private void butt2_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            webBrowser1.Visibility = Visibility.Visible;
            string Kraj = LAB1.Text;
            string hotel = "hotele";
            try
            {
                StringBuilder adres = new StringBuilder();
                adres.Append("https://www.bing.com/maps?q=");
                if (Kraj != string.Empty)
                {
                    adres.Append(Kraj + "," + "+");
                }
                if (hotel != string.Empty)
                {
                    adres.Append(hotel + "," + "+");
                }
                webBrowser1.Navigate(adres.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            trya.Visibility = Visibility.Visible;
        }

        private void butt3_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            webBrowser1.Visibility = Visibility.Visible;
            string Kraj = LAB1.Text;
            string res = "restaurant";
            try
            {
                StringBuilder adres = new StringBuilder();
                adres.Append("https://www.bing.com/maps?q=");
                if (Kraj != string.Empty)
                {
                    adres.Append(Kraj + "," + "+");
                }
                if (res != string.Empty)
                {
                    adres.Append(res + "," + "+");
                }
                webBrowser1.Navigate(adres.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            trya.Visibility = Visibility.Visible;
        }

        private void trya_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            webBrowser1.Visibility = Visibility.Hidden;
            trya.Visibility = Visibility.Hidden;
        }
    }
}

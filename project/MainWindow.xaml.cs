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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page1 page1 = new Page1();
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = page1;
        }

        private void wyjsc_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        

        private void Label_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = null;
        }

        private void Label_PreviewMouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = new Page1();
        }
    }
}

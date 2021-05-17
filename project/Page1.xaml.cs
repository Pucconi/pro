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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var win = new Window1();
            win.Show();
        }

        private void Label_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var win = new Window2();
            win.Show();
        }

        private void par_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var win = new Window2();
            win.Show();
        }
    }
 }


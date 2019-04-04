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

namespace testAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtGT_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            double s = 1;
            for ( int i = 2; i <=n; i++)
            {
                s += Math.Sqrt(i);
            }
            txtKQ.Text = s.ToString();
        }

        private void BtX_Click(object sender, RoutedEventArgs e)
        {
            int n = Int32.Parse(txtSOX.Text);
            int x = 2;
            double c = 0;
            for (int i = 1; i <= n; i++)
            {
                c += Math.Pow(x, i);
            }
            txtKq.Text = c.ToString();
        }

        private void BtM_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

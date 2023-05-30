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

namespace WpfApp41
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(Boxx.Text);
            int y = int.Parse(Boxy.Text);
            int z = max(x, 2 * y - x) + max(5 * x + 3 * y, y);
            txtOtv.Text = $"Z = {z}";
        }
    }
}

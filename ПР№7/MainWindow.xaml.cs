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

namespace ПР_7
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
        int[] arrayX;
        double[] arrayY;
        private void BtnCrtArrX_Click(object sender, RoutedEventArgs e)
        {
            LstArrayX.Items.Clear();
            arrayX = new int[27];
            Random rnd = new Random();
            for (int i = 0; i < 27; i++)
            {
                arrayX[i] = rnd.Next(-1000, 1000);
                LstArrayX.Items.Add($"#{arrayX[i]}");
            }
        }

        private void BtnCompltTsk_Click(object sender, RoutedEventArgs e)
        {
            arrayY = new double[27];
            for (int i = 0;i < 27;i++)
            {
                arrayY[i] = 6.85 * Math.Pow(arrayX[i], 2);
                LstArrayY.Items.Add(Math.Round(arrayY[i], 2));
                if (arrayY[i] < 0)
                {
                    LstArrayY.Items.Add($"#a={Math.Round(Math.Pow(arrayX[i], 3) - 0.62), 2}");
                }
                else
                {
                    LstArrayY.Items.Add($"#b={Math.Round(1.0 / Math.Pow(arrayX[i], 2), 6)}");
                }
            }
        }
    }
}

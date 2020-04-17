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

namespace InvestmentCalculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, RoutedEventArgs e)
        {
            var qtje = Convert.ToInt32(txtqtje.Text); // 起投金额
            var nfhzzl = Convert.ToSingle(txtnfhzzl.Text); // 年复合增长率
            var nztje = Convert.ToDouble(txtnztje.Text);  // 年增投金额
            var tznx = Convert.ToInt32(txttznx.Text);  // 投资年限
            double sum = 0.0f;
            double baseJE = qtje;
            for (var i = 1; i < tznx; i++)
            {
                var k = System.Math.Pow((1 + nfhzzl), 1) * baseJE;
                baseJE += nztje;
                sum += k;
            }
            txttzhb.Text = Math.Round(sum, 2).ToString("N2");

        }
    }
}

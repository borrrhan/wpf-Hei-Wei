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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double heightValue= Math.Round(HeightSlider.Value, 1);
            HeightNumber.Text = heightValue.ToString();
            double weightValue = Math.Round(WeightSlider.Value, 1);
            WeightNumber.Text = weightValue.ToString();
            Canvas.SetLeft(Height, heightValue * 1.6);
            Canvas.SetLeft(Weight, weightValue * 1.6);
        }
    }
}

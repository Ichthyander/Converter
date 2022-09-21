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

namespace Converter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        
        private void Dollar_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dollarInRoubleAmount.Text = Convert.ToString(Convert.ToDouble(dollar2RoubleRate.Text) * Convert.ToDouble(dollarAmount.Text));
            }
            catch (FormatException)
            {
                dollarInRoubleAmount.Text = "0";
            }
        }

        private void Euro_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                euroInRoubleAmount.Text = Convert.ToString(Convert.ToDouble(euro2RoubleRate.Text) * Convert.ToDouble(euroAmount.Text));
            }
            catch (FormatException)
            {
                euroInRoubleAmount.Text = "0";
            }
        }

        private void Pound_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                poundInRoubleAmount.Text = Convert.ToString(Convert.ToDouble(pound2RoubleRate.Text) * Convert.ToDouble(poundAmount.Text));
            }
            catch (FormatException)
            {
                poundInRoubleAmount.Text = "0";
            }
        }

        private void Yuan_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                yuanInRoubleAmount.Text = Convert.ToString(Convert.ToDouble(yuan2RoubleRate.Text) * Convert.ToDouble(yuanAmount.Text));
            }
            catch (FormatException)
            {
                yuanInRoubleAmount.Text = "0";
            }
        }

        private void Bar_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bar_To_kNm2.Text = Convert.ToString(Convert.ToDouble(barAmount.Text) * 100);
            }
            catch (FormatException)
            {
                bar_To_kNm2.Text = "0";
            }
        }

        private void Pascal_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pascal_To_kNm2.Text = Convert.ToString(Convert.ToDouble(pascalAmount.Text) * 0.001);
            }
            catch (FormatException)
            {
                pascal_To_kNm2.Text = "0";
            }
        }

        private void Ton_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tonm2_To_kNm2.Text = Convert.ToString(Convert.ToDouble(tonm2Amount.Text) * 9.80665);
            }
            catch (FormatException)
            {
                tonm2_To_kNm2.Text = "0";
            }
        }

        private void Atmosphere_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                atmosphere_To_kNm2.Text = Convert.ToString(Convert.ToDouble(atmosphereAmount.Text) * 101.325);
            }
            catch (FormatException)
            {
                atmosphere_To_kNm2.Text = "0";
            }
        }
    }
}

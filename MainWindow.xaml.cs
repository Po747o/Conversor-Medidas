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

namespace ConversorDeMedidas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;


            
           
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            cbTipo.SelectedIndex = 0;
            edValor1.IsEnabled = false;
        }


        private void cbTipo_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void cbTipo_Selected_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void cbTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    label1.Content = "";
                    label2.Content = "";
                    edValor1.IsEnabled = false;
                    edValor1.Text = "";
                    edValor2.IsEnabled = false;
                    edValor2.Text = "";
                    btConverter.IsEnabled = false;
                    break;

                case 1:
                    label1.Content = "Centimetros";
                    label2.Content = "Metros";
                    edValor1.IsEnabled = true;
                    edValor1.Text = "0";
                    edValor2.IsEnabled = true;
                    edValor2.Text = "0";
                    btConverter.IsEnabled = true;
                    break;

                case 2:
                    label1.Content = "Metros";
                    label2.Content = "Centimetros";
                    edValor1.IsEnabled = true;
                    edValor1.Text = "0";
                    edValor2.IsEnabled = true;
                    edValor2.Text = "0";
                    btConverter.IsEnabled = true;
                    break;

                case 3:
                    label1.Content = "Metros";
                    label2.Content = "Quilometros";
                    edValor1.IsEnabled = true;
                    edValor1.Text = "0";
                    edValor2.IsEnabled = true;
                    edValor2.Text = "0";
                    btConverter.IsEnabled = true;
                    break;

                case 4:
                    label1.Content = "Quilometros";
                    label2.Content = "Metros";
                    edValor1.IsEnabled = true;
                    edValor1.Text = "0";
                    edValor2.IsEnabled = true;
                    edValor2.Text = "0";
                    btConverter.IsEnabled = true;
                    break;

                case 5:
                    label1.Content = "Decimal";
                    label2.Content = "Porcentagem";
                    edValor1.IsEnabled = true;
                    edValor1.Text = "0";
                    edValor2.IsEnabled = true;
                    edValor2.Text = "0%";
                    btConverter.IsEnabled = true;
                    break;

                case 6:
                    label1.Content = "Porcentagem";
                    label2.Content = "Decimal";
                    edValor1.IsEnabled = true;
                    edValor1.Text = "0%";
                    edValor2.IsEnabled = true;
                    edValor2.Text = "0";
                    btConverter.IsEnabled = true;
                    break;
            }
              
            
        }

        private void btConverter_Click(object sender, RoutedEventArgs e)
        {

            switch (cbTipo.SelectedIndex)
            {
                case 1:
                    double num1 = Convert.ToDouble(edValor1.Text);
                    double num2 = num1 / 100;
                    edValor2.Text = Convert.ToString(num2);

                    break;

                case 2:
                     num1 = Convert.ToDouble(edValor1.Text);
                     num2 = num1 * 100;
                    edValor2.Text = Convert.ToString(num2);

                    break;

                case 3:
                     num1 = Convert.ToDouble(edValor1.Text);
                     num2 = num1 / 1000;
                    edValor2.Text = Convert.ToString(num2);

                    break;

                case 4:
                    num1 = Convert.ToDouble(edValor1.Text);
                    num2 = num1 * 1000;
                    edValor2.Text = Convert.ToString(num2);

                    break;

                case 5:
                     num1 = Convert.ToDouble(edValor1.Text);
                     num2 = num1 * 100;
                    edValor2.Text = Convert.ToString(num2) +"%";

                    break;

                case 6:
                    num1 = Convert.ToDouble(edValor1.Text);
                    num2 = num1 / 100;
                    edValor2.Text = Convert.ToString(num2);

                    break;
            }
        }
    }
}

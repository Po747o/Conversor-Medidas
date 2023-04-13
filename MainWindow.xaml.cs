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

        public  double Calculadora(double valor)
        {
            double resul;
            resul = valor * 1;

            return resul;
        }

        private void cbTipo_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void cbTipo_Selected_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TESte");
        }

        private void cbTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbTipo.SelectedIndex != 0)
            {
                edValor1.IsEnabled = true; 
                edValor1.Text = "0,00";

            } 
            else 
            {
                edValor1.IsEnabled = false;
                edValor1.Text = "";
            }
        }
    }
}

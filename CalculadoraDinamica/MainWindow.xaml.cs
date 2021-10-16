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

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            const int maximasFilas = 4;
            const int maximasColumnas = 2;
            int numero = 1;
            Grid grid = (Grid) this.Content;
            for (int i = 2; i <= maximasFilas; i++)
            {
                for (int j = 0; j <= maximasColumnas; j++)
                {
                    Button button = new Button
                    {
                        Content = numero,
                        Tag = numero                      
                    };
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    grid.Children.Add(button);
                    numero++;
                }
            }         
            this.Content = grid;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text += ((Button)sender).Tag;
        }
    }
}

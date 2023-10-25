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

namespace Tema3_CalculadoraEstilosDinamica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int f = 1; f <= 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    int number = c + 1 + (f - 1) * 3;

                    Button button = new Button
                    {
                        Content = number.ToString(),
                        FontSize = 36,
                        FontWeight = FontWeights.Bold,
                        Margin = new Thickness(5)
                    };

                    Grid.SetRow(button, f);
                    Grid.SetColumn(button, c);

                    button.Click += Button_Click;

                    myGrid.Children.Add(button); 
                }
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string buttonText = button.Content.ToString();

                recuadroMuestraNumero.Text += buttonText;
            }
        }
    }
}

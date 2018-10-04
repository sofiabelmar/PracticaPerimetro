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

namespace PracticaPerimetro
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbtipofigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controlPerimetroCirculo.Visibility = Visibility.Collapsed;
            controlPerimetroCuadrado.Visibility = Visibility.Collapsed;

            switch (cbtipofigura.SelectedIndex)
            {
                case 0:
                    controlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;
                case 1:
                    controlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;
                case 2:
                    controlPerimetroRectangulo.Visibility = Visibility.Visible;
                    break;
                case 3:
                    controlPerimetroTrapecio.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
                
            }
        }

        private void btncalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;
            switch (cbtipofigura.SelectedIndex)
            {
                case 0:
                    float radio = float.Parse(controlPerimetroCirculo.txtRadio.Text);
                    perimetro = 2 * radio * 3.1416f;
                    break;
                case 1:
                    float lado = float.Parse(controlPerimetroCuadrado.txtlado.Text);
                    perimetro = lado * 4;
                    break;
                case 2:
                    float lado1 = float.Parse(controlPerimetroRectangulo.txtlado1.Text);
                    float lado2 = float.Parse(controlPerimetroRectangulo.txtlado2.Text);
                    perimetro = lado1 + lado1 + lado2 + lado2;
                    break;
                case 3:
                    float ladoA = float.Parse(controlPerimetroTrapecio.txtladoA.Text);
                    float ladoB = float.Parse(controlPerimetroTrapecio.txtladoB.Text);
                    float ladoC = float.Parse(controlPerimetroTrapecio.txtladoC.Text);
                    float ladoD = float.Parse(controlPerimetroTrapecio.txtladoD.Text);
                    perimetro = ladoA + ladoB + ladoC + ladoD;
                    break;
                default:
                    break;

            }
            lblrestultado.Text = perimetro.ToString();
        }
    }
}

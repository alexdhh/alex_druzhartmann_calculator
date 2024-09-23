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

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BTN_Cos.IsEnabled = false;
            BTN_Sin.IsEnabled = false;
            BTN_Tan.IsEnabled = false;
            BTN_Sqrt.IsEnabled = false; 
        }

        // définition des variables

        double nb1, nb2, result;
        char operation;

        // fonctions events; activation des différents boutons
        // sous chaque event impliquant un opérateur, on a une condition qui permet de ne pas faire crash le programme si un opérateur est saisi avant un nombre

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            Display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            Display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            Display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            Display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            Display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            Display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            Display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            Display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            Display("9");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                TB_Display.Text = "";
                operation = '+';
            }
        }

        private void BTN_Sustract_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                TB_Display.Text = "";
                operation = '-';
            }
        }

        private void BTN_Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                TB_Display.Text = "";
                operation = '*';
            }
        }

        private void BTN_Divide_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                TB_Display.Text = "";
                operation = '/';
            }
        }

        private void BTN_Percentage_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                result = nb1 / 100;
                TB_Display.Text = "";
                TB_DisplayResult.Text = result.ToString();
            }
        }

        private void BTN_Comma_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = "0,";
            }
            else
            {
                Display(",");
            }
        }

        private void BTN_Square_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                result = nb1 * nb1;
                TB_Display.Text = "";
                TB_DisplayResult.Text = result.ToString();
            }
        }

        private void BTN_Clear_Click(object sender, RoutedEventArgs e)
        {
            nb1 = 0;
            nb2 = 0;
            result = 0;
            operation = '\0';
            TB_Display.Text = "";
            TB_DisplayResult.Text = "";
        }

        private void BTN_Sci_Click(object sender, RoutedEventArgs e)
        {
            if (BTN_Sqrt.IsEnabled == true)
            {
                BTN_Sqrt.IsEnabled = false;
                BTN_Cos.IsEnabled = false;
                BTN_Sin.IsEnabled = false;
                BTN_Tan.IsEnabled = false;
            }
            else
            {
                BTN_Sqrt.IsEnabled = true;
                BTN_Cos.IsEnabled = true;
                BTN_Sin.IsEnabled = true;
                BTN_Tan.IsEnabled = true;
            }
        }

        private void BTN_Equal_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb2 = double.Parse(TB_Display.Text);
                TB_Display.Text = "";
                switch (operation)
                {
                    case '+':
                        result = nb1 + nb2;
                        break;

                    case '-':
                        result = nb1 - nb2;
                        break;

                    case '*':
                        result = nb1 * nb2;
                        break;

                    case '/':
                        result = nb1 / nb2;
                        break;
                }
                TB_DisplayResult.Text = result.ToString();

                //tesds

            }
        }

        private void BTN_Sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                result = Math.Sqrt(nb1);
                TB_DisplayResult.Text = result.ToString();
                TB_Display.Text = "";
            }
        }

        private void BTN_Cos_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                result = Math.Cos(nb1);
                TB_DisplayResult.Text = result.ToString();
                TB_Display.Text = "";
            }
        }

        private void BTN_Sin_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                result = Math.Sin(nb1);
                TB_DisplayResult.Text = result.ToString();
                TB_Display.Text = "";
            }
        }

        private void BTN_Tan_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "")
            {
                Display("");
            }
            else
            {
                nb1 = double.Parse(TB_Display.Text);
                result = Math.Tan(nb1);
                TB_DisplayResult.Text = result.ToString();
                TB_Display.Text = "";
            }
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            Display("0");
        }

        // fonction Display; permet de correctement afficher les numéros saisis depuis nos boutons
        private void Display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text += num;
            }
        }
    }
}

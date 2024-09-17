using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace alex_druzhartmann_calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int nb1, nb2, result;
        char operation;

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display("0");
        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display("9");
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            nb1 = int.Parse(TB_Display.Text);
            TB_Display.Text = "";
            operation = '+';
        }

        private void BTN_Sustract_Click(object sender, RoutedEventArgs e)
        {
            nb1 = int.Parse(TB_Display.Text);
            TB_Display.Text = "";
            operation = '-';
        }

        private void BTN_Multiply_Click(object sender, RoutedEventArgs e)
        {
            nb1 = int.Parse(TB_Display.Text);
            TB_Display.Text = "";
            operation = '*';
        }

        private void BTN_Divide_Click(object sender, RoutedEventArgs e)
        {
            nb1 = int.Parse(TB_Display.Text);
            TB_Display.Text = "";
            operation = '/';
        }

        private void BTN_Clear_Click(object sender, RoutedEventArgs e)
        {
            nb1 = 0;
            nb2 = 0;
            result = 0;
            operation = '\0';
            TB_Display.Text = "";


        }
        private void BTN_Equal_Click(object sender, RoutedEventArgs e)
        {
            nb2 = int.Parse(TB_Display.Text);
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
            string conversion = result.ToString();
            TB_Display.Text = conversion;
        }

        private void display(string num)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = num;
            }
            else
            {
                TB_Display.Text = TB_Display.Text + num;
            }
        }

    }
}

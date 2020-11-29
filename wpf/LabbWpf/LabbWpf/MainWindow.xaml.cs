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

namespace LabbWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_click(object sender, RoutedEventArgs e)
        {
            if(e.Source is Button button)
            {
                switch (button.Content)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "+":
                    case "-":
                    case "^":
                    case "x":
                    case "/":
                    case "√":
                    case ",":
                        InOutField.Text += button.Content;
                        break;
                    case "=":
                        if (InOutField.Text.Contains('+'))
                        {
                            InOutField.Text = calculatorAlgorithm('+');
                        }

                        else if (InOutField.Text.Contains('-'))
                        {
                            InOutField.Text = calculatorAlgorithm('-');
                        }

                        else if (InOutField.Text.Contains('/'))
                        {
                            InOutField.Text = calculatorAlgorithm('/');
                        }

                        else if (InOutField.Text.Contains('x'))
                        {
                            InOutField.Text = calculatorAlgorithm('x');
                        }

                        else if (InOutField.Text.Contains('^'))
                        {
                            InOutField.Text = calculatorAlgorithm('^');
                        }

                        else if (InOutField.Text.Contains('√'))
                        {
                            InOutField.Text = calculatorAlgorithm('√');
                        }

                        break;

                    case "Clear":
                        InOutField.Text = "";
                        break;

                    default:
                        break;

                        
                }

               

            }
        }
        private string calculatorAlgorithm(char mathOperator)
        {
            var result = 0.0;

            var numberContainer = InOutField.Text.Split('+', '-', 'x', '√', '^', '/');

            if(numberContainer[0] == "")
            {
                numberContainer[0] = "1";
            }
            
            var firstNumber = Convert.ToDouble(numberContainer[0]);
            var secondNumber = Convert.ToDouble(numberContainer[1]);

            

            switch (mathOperator)
                    {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '^':
                    result = Math.Pow(firstNumber, secondNumber);
                    break;

                case 'x':
                    result = firstNumber * secondNumber;
                    break;

                case '/':
                    result = firstNumber / secondNumber;
                    break;

                case '√':
                    result = Math.Sqrt(secondNumber);
                    break;

                default:
                        break;
            }
            var resultView = Convert.ToString(result);
            return resultView;
        }
    }
}

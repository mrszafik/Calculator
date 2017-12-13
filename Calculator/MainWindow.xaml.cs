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

namespace Calculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string _number1_String, _number2_String;
        private double _result, _number1, _number2;
        private char _chosenAction;
        private Boolean _nextNumber = false;

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("1");
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("2");
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("3");
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("4");
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("5");
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("6");
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("7");
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("8");
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("9");
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber("0");
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            _nextNumber = true;
            _chosenAction = '+';
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            _nextNumber = true;
            _chosenAction = '*';
        }

        private void ButtonSubb_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            _nextNumber = true;
            _chosenAction = '-';
        }

        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {
            DisplayNumber(",");
        }

        private void ButtonChangeSign_Click(object sender, RoutedEventArgs e)
        {
            _number1 = double.Parse(_number1_String);
            _number1 = _number1 * (-1.0);
            _number1_String = _number1.ToString();
            Display.Text = _number1_String;
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            _nextNumber = true;
            _chosenAction = '/';
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            _number1 = double.Parse(_number1_String);
            _number2 = double.Parse(_number2_String);
            switch (_chosenAction)
            {
                case ('+'):
                    _result = Math.Round(_number1 + _number2, 3);

                    break;

                case ('-'):
                    _result = Math.Round(_number1 - _number2, 3);
                    break;

                case ('*'):
                    _result = Math.Round(_number1 * _number2, 3);
                    break;

                case ('/'):
                    _result = Math.Round(_number1 / _number2, 3);
                    break;
                case (' '):
                    break;
            }
            _chosenAction = ' ';
            Display.Text= _result.ToString();
            _number1 = _result;
            _number1_String = _number1.ToString();
            _number2_String = " ";
        }

        private void DisplayNumber(string number)
        {
            if (!_nextNumber)
            {
                _number1_String += number;
                Display.Text = _number1_String;
            }
            else
            {
                _number2_String += number;
                Display.Text = _number2_String;
            }

        }
    }

}
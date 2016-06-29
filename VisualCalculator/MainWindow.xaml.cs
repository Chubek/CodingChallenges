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

namespace VisualCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public List<string> CurrentDigit = new List<string>(); //list that holds pressed digits
        public List<float> Operands = new List<float>(); //list that holds operands
        public string Operator;
        

        public void Concatenate (string digit)
        {
            CurrentDigit.Add(digit);
            
        }

        public void NumberUpdate()
        {
            string digitsToShow = string.Join("", CurrentDigit.ToArray()); //create a string from the digits list
            NumberBox.Text = digitsToShow; //show the digits
            if (CurrentDigit.Count == 0)
            {
                NumberBox.Text = "0";
            }
        }

        public void ParseCurrent ()
        {
            string digitsToParse = string.Join("", CurrentDigit.ToArray());
            float operandToAdd = float.Parse(digitsToParse);
            Operands.Add(operandToAdd);
            CurrentDigit.Clear();
        }
       

        public void Result()
        {
            if (Operands.Count > 1)
            {
                float result = 0;

                switch (Operator)
                {
                    case "/":
                        result = Operands[0] / Operands[1];
                        break;
                    case "*":
                        result = Operands[0] * Operands[1];
                        break;
                    case "+":
                        result = Operands[0] + Operands[1];
                        break;
                    case "-":
                        result = Operands[0] - Operands[1];
                        break;

                }

                Operands.Clear();
                Operands.Add(result);

                NumberBox.Text = result.ToString();
            }
        }
       

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("7");
            NumberUpdate();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("8");
            NumberUpdate();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("9");
            NumberUpdate();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("4");
            NumberUpdate();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("5");
            NumberUpdate();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("6");
            NumberUpdate();
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("1");
            NumberUpdate();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("2");
            NumberUpdate();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Concatenate("3");
            NumberUpdate();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentDigit.Count == 0)
            {
                return; //if the first digit is zero, abort
            }
            else
            {
                Concatenate("0"); //add a decimal point
                NumberUpdate();
            }
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentDigit.Contains("."))
            {
                return; //abort if the list contains a decimal point
            }
            else
            {

                Concatenate("."); //add a decimal point
                NumberUpdate();
            }
          
        }

        private void PlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentDigit.Contains("-"))
            {
                return; //abort if the number is already negative
            }
            else if (NumberBox.Text == "0")
            {
                return; //abort if the digit is zero
            }
            else
            {
                CurrentDigit.Insert(0, "-"); //add a negative sign
                NumberUpdate();
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            ParseCurrent();
            Operator = "/";
            Result();
            
            
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            ParseCurrent();
            Operator = "*";
            Result();

        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            ParseCurrent();
            Operator = "+";
            Result();

        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            ParseCurrent();
            Operator = "-";
            Result();

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CurrentDigit.Clear();
            Operands.Clear();
            NumberBox.Text = "0";
        }

        private void BackSlash_Click(object sender, RoutedEventArgs e)
        {
            if (NumberBox.Text == "0")
            {
                return;
            }          
            else if (CurrentDigit.Count == 0)
            {
                NumberBox.Text = "0";
            } 
            else
            {
                CurrentDigit.RemoveAt((CurrentDigit.Count) - 1);
                NumberUpdate();
            }
            
            
         }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Result();
        }
    }
}

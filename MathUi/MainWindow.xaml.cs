using System;
using System.Windows;
using MathOperations;

namespace MathUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate calc = new Calculate();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckValues();
            if (calc.isIncorrect == false)
            {
                Output.Text = calc.Addition().ToString();
            }
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            CheckValues();
            if (calc.isIncorrect == false)
            {
                Output.Text = calc.Subtraction().ToString();
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            CheckValues();
            if (calc.isIncorrect == false)
            {
                Output.Text = calc.Multiplication().ToString();
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            CheckValues();
            if (calc.isIncorrect == false)
            {
                Output.Text = calc.Division();
            }
        }

        private void CheckValues()
        {
            if (!string.IsNullOrWhiteSpace(Output.Text) && calc.isIncorrect == false)
            {
                UpdateList();
            }
            calc.isIncorrect = false;
            try
            {
                calc.x = int.Parse(XValue.Text);
                calc.y = int.Parse(YValues.Text);
            }
            catch (Exception ex)
            {
                calc.isIncorrect = true;
                Output.Text = "Please Input Numbers for Values";
            }
        }

        private void UpdateList()
        {
            OtherOutputs.Items.Add(Output.Text);
        }
    }
}

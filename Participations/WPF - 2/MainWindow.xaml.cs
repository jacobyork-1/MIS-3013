//Jacob York
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

namespace WPF___2
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

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            string numberInput;
            numberInput = txtNumber.Text;
            int numberInputAsNumber = Convert.ToInt32(numberInput);
            string[] numberArray = numberInput.Split(',');
            foreach (var number in numberArray)
            {
                if (numberInputAsNumber % 2 == 0)
                {
                    lstNumber.Items.Add(numberInputAsNumber);
                }
                else
                {
                    lstNumber.Items.Add(numberInputAsNumber);
                }
            }

        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumber.Clear();
            lstNumber.Items.Clear();
        }

        private void rbODD_Checked(object sender, RoutedEventArgs e)
        {
            string numberInput;
            numberInput = txtNumber.Text;
            int numberInputAsNumber = Convert.ToInt32(numberInput);
            string[] numberArray = numberInput.Split(',');
            if (rbODD.IsChecked == true)
            {
                {
                    if (numberInputAsNumber % 2 == 0)
                    {
                        lstNumber.Items.Add(numberInputAsNumber);
                    }
                }
            }
            else
            {
                lstNumber.Items.Add(numberInputAsNumber);
            }
        }
    }
}

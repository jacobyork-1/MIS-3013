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

namespace WPF___Student
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
            string firstName, lastName, favoriteColor, studentID;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            favoriteColor = txtFavoriteColor.Text;
            studentID = txtStudentID.Text;
            int studentIDasNumber = Convert.ToInt32(studentID);

            lstListBox.Items.Add(firstName);
            lstListBox.Items.Add(lastName);
            lstListBox.Items.Add(favoriteColor);
            lstListBox.Items.Add(studentIDasNumber);

            MessageBox.Show($"{firstName} {lastName}s studentID number is {studentIDasNumber} and has a favorite color of {favoriteColor}.");
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtFavoriteColor.Clear();
            txtStudentID.Clear();
            lstListBox.Items.Clear();


        }

    }
}

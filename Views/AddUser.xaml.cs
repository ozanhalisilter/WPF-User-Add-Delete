using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for Add_User.xaml
    /// </summary>
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string[] allLines = File.ReadAllLines(System.IO.Path.ChangeExtension("people.csv", ".csv"));

            //TODO Async programming +8K line
            // tekrar csv read 
            

            string[] arr = new string[] { name.Text, surname.Text, age.Text, address.Text };
            string line = string.Join(",", arr);
            MessageBox.Show(line);

        }
    }
}


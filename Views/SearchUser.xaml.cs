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
    /// Interaction logic for Search_User.xaml
    /// </summary>
    public partial class SearchUser : UserControl
    {

        List<Person> people = new List<Person>();
        public SearchUser()
        {
            InitializeComponent();
            //people.Add(new Person("Ozan", "Halis", 23, "adawdjiwadjdiwa"));
            //myCombo.ItemsSource = people;

           // SQLite ile degistir
           myCombo.ItemsSource = ReadCSV(@"C:\GitHub2\WPF\WpfApp1\people");

            //

        }

        public IEnumerable<Person> ReadCSV(string fileName)
        {   
            //try cath ekle
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));
            

            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                return new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3]);
            });
        }

        private void myCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cbo = sender as ComboBox;
            var selItem = cbo.SelectedItem;
            myText.Text = selItem.ToString();

        }

      
    }
}

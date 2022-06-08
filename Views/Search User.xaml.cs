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
    public partial class Search_User : UserControl
    {

        List<Person> people = new List<Person>();
        public Search_User()
        {
            InitializeComponent();
            people.Add(new Person("Ozan", "Halis", 23, "adawdjiwadjdiwa"));
            DataContext = people;
            //myCombo.ItemsSource = people;
            string objects = ReadCSV(@"C:\GitHub2\WPF\WpfApp1\people").First().FirstName.ToString();
            MessageBox.Show(objects);
            
            ; ;

            //

        }
        public IEnumerable<Person> ReadCSV(string fileName)
        {
            string[] lines = File.ReadAllLines(System.IO.Path.ChangeExtension(fileName, ".csv"));

            return lines.Select(line =>
            {
                string[] data = line.Split(';');
                return new Person(data[0], data[1], Convert.ToInt32(data[2]), data[3]);
            });
        }
        public class Person
        {
            public Person(string v1, string v2, int v3, string v4)
            {
                FirstName = v1;
                LastName = v2;
                Age = v3;
                Address = v4;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }

            public string FullName
            {
                get { return $"{FirstName} {LastName}"; }

            }

            
        }


    }
}

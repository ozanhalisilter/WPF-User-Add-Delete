namespace WpfApp1.Views
{
    public partial class SearchUser //Delete
    {
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

            public string V1 { get; }
            public string V2 { get; }
            public int V3 { get; }
            public string V4 { get; }


            public override string ToString()
            {
                return $"{FullName} {Age} {Address}";
            }
        }

      
    }
}

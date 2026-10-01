using System;

namespace MyApp
{
    class Encapusion
    {
        private string name = string.Empty;
        private int age = 0;
        private string address = string.Empty;
        private int id = 0;

        public string Name
        {
            // get { return name; }
            // set { name = value; }
            get; set;
        }

        public int Age
        {
            // get { return age; }
            // set { age = value; }
            get; set;
        }

        public string Address
        {
            // get { return address; }
            // set { address = value; }
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Address: {address}, ID: {id}");
        }
    }
}

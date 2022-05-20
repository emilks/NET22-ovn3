using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age 
        {
            get { return age; }
            set {
                if(value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Måste vara större än 0");
                }
            } 
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Person(string newFName, string newLName)
        {
            if(newFName.Length < 2 || newFName.Length > 10)
            {
                Console.WriteLine("Förnamn måste vara mellan 2 och 10 bokstäver");
                throw new ArgumentException();
            }
            if (newLName.Length < 3 || newLName.Length > 15)
            {
                Console.WriteLine("Efternamn måste vara mellan 3 och 15 bokstäver");
                throw new ArgumentException();
            }
            fName = newFName;
            lName = newLName;
        }

    }
}

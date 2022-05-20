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
            set {
                if (value.Length < 2 || value.Length > 10)
                {
                    Console.WriteLine("Förnamn måste vara mellan 2 och 10 bokstäver");
                    throw new ArgumentException();
                }
                fName = value; 
            }
        }

        public string LName
        {
            get { return lName; }
            set {
                if (value.Length < 3 || value.Length > 15)
                {
                    Console.WriteLine("Efternamn måste vara mellan 3 och 15 bokstäver");
                    throw new ArgumentException();
                }
                lName = value; 
            }
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
            FName = newFName;
            LName = newLName;
        }

    }
}

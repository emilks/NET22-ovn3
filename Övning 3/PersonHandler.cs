using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }
        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person nPerson = new Person(fname, lname);
            nPerson.Age = age;
            nPerson.Height = height;
            nPerson.Weight = weight;
            return nPerson;
        }
    }
}

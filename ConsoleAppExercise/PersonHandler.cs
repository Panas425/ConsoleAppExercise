using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class PersonHandler
    {
        public void SetAge(Person person, int age) { 
            person.Age = age;
        }
        public void SetFname(Person person, string fname)
        {
            person.FName = fname;
        }
        public void SetLname(Person person, string lname)
        {
            person.LName = lname;
        }
        public void SetHeight(Person person, double height)
        {
            person.Height = height;
        }
        public void SetWeight(Person person, double weight)
        {
            person.Weight = weight;
        }
        public static Person CreatePerson(int age, string fname, string lname, double height, double weight) { 
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;
            return person;
        }
    }
}

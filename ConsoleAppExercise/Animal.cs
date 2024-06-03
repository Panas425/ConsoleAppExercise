using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    abstract class Animal
    {
        public string name { get; set; }
        public double weight { get; set; }
        public int age { get; set; }

        public abstract string DoSound();
        public abstract string Stats();

        public Animal(string name, double weight, int age) { 
            this.name = name;
            this.weight = weight;
            this.age = age; 
        }
    }
}

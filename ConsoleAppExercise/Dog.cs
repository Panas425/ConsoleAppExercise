using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppExercise
{
    internal class Dog : Animal
    {
        private int Aggressiveness { get; set; }
        public Dog(string name, double weight, int age, int aggressiveness) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            Aggressiveness = aggressiveness;
        }

        public override string DoSound()
        {
            return "VOV VOV";
        }
        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, Aggressiveness: {Aggressiveness}";
        }
        public string Test() {
            return "DOGTEST";
        }
    }
}

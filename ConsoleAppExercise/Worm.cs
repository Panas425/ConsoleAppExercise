using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Worm : Animal
    {
        public bool IsPoisnous { get; set; }    
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public Worm(string name, double weight, int age, bool isPoisnous) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            IsPoisnous = isPoisnous;
        }

        public override string DoSound()
        {
            return "SLITHHH";
        }
        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Is Poisnous: {IsPoisnous}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Bird : Animal
    {
        public int WingSpan { get; set; }
        public Bird(string name, double weight, int age, int WingSpan) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;  
            this.age = age;
            this.WingSpan = WingSpan;
        }

        public override string DoSound()
        {
            return "TWEET TWEET";
        }

        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, WingSpan: {WingSpan}";
        }
    }
}

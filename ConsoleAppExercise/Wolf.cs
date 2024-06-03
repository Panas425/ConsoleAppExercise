using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Wolf : Animal
    {
        public int PackSize { get; set; }   
        public Wolf(string name, double weight, int age, int packSize) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            PackSize = packSize;
        }

        public override string DoSound()
        {
            return "AWOOoo";
        }
        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, PackSize: {PackSize}";
        }

    }
}

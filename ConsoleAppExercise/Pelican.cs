using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Pelican : Bird
    {
        public double BeakLength { get; set; }
        public Pelican(string name, double weight, int age, int WingSpan, double beakLength) : base(name, weight, age, WingSpan)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.WingSpan = WingSpan;
            BeakLength = beakLength;
        }

        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, WingSpan: {WingSpan}, Beak Length: {BeakLength}";
        }
        public override string DoSound()
        {
            return "uurk";
        }
    }
}

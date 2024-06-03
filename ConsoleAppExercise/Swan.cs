using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Swan : Bird
    {
        public double NeckLength { get; set; }
        public Swan(string name, double weight, int age, int WingSpan, double neckLength) : base(name, weight, age, WingSpan)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.WingSpan = WingSpan;
            NeckLength = neckLength;
        }
        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, WingSpan: {WingSpan}, Neck Length: {NeckLength}";
        }
        public override string DoSound()
        {
            return "whistle";
        }
    }
}

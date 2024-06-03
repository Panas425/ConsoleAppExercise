using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Hedgehog : Animal
    {
        public int NbrOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, int nbrOfSpikes) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            NbrOfSpikes = nbrOfSpikes;
        }

        public override string DoSound()
        {
            return "SNUFF";
        }

        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, NbrOfSpikes: {NbrOfSpikes}";
        }
    }
}

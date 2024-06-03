using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Horse : Animal
    {
        public string Breed {  get; set; }

        public Horse(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            Breed = breed;
        }

        public override string DoSound()
        {
            return "NEIGH";
        }
        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, Breed: {Breed}";
        }
    }
}

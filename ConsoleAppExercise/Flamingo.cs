using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Flamingo : Bird
    {
        public string FavoritFood { get; set; }
        public Flamingo(string name, double weight, int age, int WingSpan, string favoritFood) : base(name, weight, age, WingSpan)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            this.WingSpan = WingSpan;
            FavoritFood = favoritFood;
        }
        public override string Stats()
        {
            return $"Name: {name}, Age: {age}, Weight: {weight}, WingSpan: {WingSpan}, Favorit Food: {FavoritFood}";
        }
        public override string DoSound()
        {
            return "squawk-squawk";
        }
    }
}

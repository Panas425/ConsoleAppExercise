using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise
{
    internal class Wolfman : Wolf,IPerson
    {
        public Wolfman(string name, double weight, int age, int packSize) : base(name, weight, age, packSize)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
            PackSize = packSize;
        }

        public string Talk()
        {
            return "I AM A WOLFMAN";
        }
    }
}

//13. Om alla fåglar ska ha en ny gemensam atttribut läggs den nya i Bird klassen
//14. Om alla djur behöver den nya läggs detta i Animal klassen

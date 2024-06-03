// See https://aka.ms/new-console-template for more information
using ConsoleAppExercise;
using System.ComponentModel;
try {
    //Person person = new Person();
    //person.Age = 12;
    //person.FName = "t";
    //person.LName = "eeee";
    //Console.WriteLine($"{person.FName} {person.LName}, Age: {person.Age}, Height: {person.Height}, Weight: {person.Weight}");

    //Person person1 = PersonHandler.CreatePerson(1, "1åååå", "eweee", 123.4, 124.4);

    //Console.WriteLine($"Age: {person1.Age}, {person1.FName} {person1.LName}, Height: {person1.Height}, Weight: {person1.Weight}");

    //List<UserError> errors = new List<UserError>();

    //errors.Add(new TextInputError());
    //errors.Add(new NumericInputError());
    //errors.Add(new TestError1());
    //errors.Add(new TestError2());
    //errors.Add(new TestError3());


    //foreach (UserError error in errors) {
    //    Console.WriteLine(error.UEMessage());
    //}

    List<Animal> animals = new List<Animal>();

    animals.Add(new Horse("Horse", 125,20, "Arabic Horse"));
    animals.Add(new Hedgehog("Hedgehog", 5, 6, 124));
    animals.Add(new Wolfman("Wolfman", 80, 24, 4));
    animals.Add(new Bird("Bird", 8.7, 9, 35));
    animals.Add(new Wolf("Wolf", 57, 15, 7));
    animals.Add(new Swan("Swan", 89, 19, 23, 15));
    animals.Add(new Dog("Dog", 23, 44, 4));



    //9.Funkar ej eftersom Horse ärver inte Dog
    //List<Dog> dog = new List<Dog>();
    //dog.Add(new Horse("Horse", 125, 14, "Arabic Horse"));

    //10. Listan måste vara av typen Object
    List<Object> list = new List<Object>();



    //13.Animal-listan som innehåller olika typer av djur som loopas och för varje animal-object skrivs ut deras Stats
    //med hjälp av a-Stats(), a är objekten som Animal innehåller
    foreach (var animal in animals)
    {
        //Console.WriteLine(a.GetType().Name);
        //Console.WriteLine(a.Stats());
        //Console.WriteLine(a.DoSound() + "\n");

        //if (a is IPerson) { 
        //    IPerson person = (IPerson)a;
        //    Console.WriteLine("Sound of Person: " + person.Talk() + "\n");
        //}
        if (animal is Dog) {
            Console.WriteLine(animal.Stats());

            //17. Kommer inte åt metoden Test eftersom klassen Animal innehåller inte
            //en abstact metod som kallas för test, vilket gör att den är okänd
            //Console.WriteLine(a.Test());

            //För att kunna anropa metoden måste man typkonvertera animal objektet till
            //dog
            Dog dog = (Dog) animal;
            Console.WriteLine(dog.Test());
        }
    }

}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
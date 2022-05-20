using System;

//3.3.13) Om vi vill ha ett attribut för alla fåglar ska vi lägga det i Bird klassen
//3.3.14) Om vi vill ha ett attribut som gäller alla djur borde det vara i Animal klassen

//3.4.9) Dog och Horse må båda ärva av den abstrakta klassen Animal men en Horse är inte en Dog
//3.4.10) För att kunna lagra alla klasserna i samma lista så måste listan vara av klassen Animal efter som alla andra klasser baseras på den
//3.4.13) Den använder alltid den metoden med override för den specifika klassen
//3.4.17) Eftersom inte metoden finns deklarerad i Animal så kan vi inte komma åt den

namespace Övning_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PersonHandler p = new PersonHandler();

                Person jag = p.CreatePerson(29, "Emil", "Keski-Seppälä", 1.80, 60);
                //Person jag = new Person("Emil", "Keski-Seppälä");
                //jag.Age = 29;

                Console.WriteLine($"Person is {jag.FName} {jag.LName} of age {jag.Age}");


                p.SetAge(jag, -20);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"ArgumentException source: {e.Message}");

            }
            Console.WriteLine("Test");


            //3.2 UserError
            List<UserError> ueList = new List<UserError>();
            ueList.Add(new NumericInputError());
            ueList.Add(new TextInputError());
            ueList.Add(new NonPositiveInputError());
            ueList.Add(new EmptyInputError());
            ueList.Add(new TooLargeIntInputError());
            foreach (var error in ueList)
            {
                Console.WriteLine(error.UEMessage());
            }

            Wolfman werewolf = new Wolfman("Big Bad Wolf", 60, 35);
            //Console.WriteLine($"The wolfman {werewolf.DoSound()} or says \"{werewolf.Talk()}\"");

            List<Animal> animals = new List<Animal>();
            animals.Add(werewolf);
            animals.Add(new Dog("Lassie", 30, 6));
            animals.Add(new Horse("Bucephalus", 150, 12));
            animals.Add(new Pelican("Birdie", 15, 8));
            animals.Add(new Bird("Polly", 12, 4));
            animals.Add(new Worm("Dune", 0.5, 1));

            foreach(var animal in animals)
            {
                Console.WriteLine($"The {animal.type} makes the sound: {animal.DoSound()}");
                if(animal is IPerson)
                {
                    IPerson animalPerson = (IPerson)animal;
                    Console.WriteLine($"It also says: {animalPerson.Talk()}");
                }
            }

            List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Horse("Bucephalus", 150, 12)); //Funkar inte

            Console.WriteLine("\n Stats för alla djur i listan:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());

            }
            Console.WriteLine("\n Stats för hundar i listan:");
            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    Console.WriteLine(animal.Stats());
                    //animal.Run();  //Funkar inte
                    Dog dog = animal as Dog;
                    Console.WriteLine(dog.Runs());
                    
                }
            }
        }
    }
}
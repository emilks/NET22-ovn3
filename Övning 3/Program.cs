using System;

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

            Wolfman werewolf = new Wolfman();
            Console.WriteLine($"The wolfman {werewolf.DoSound()} or says \"{werewolf.Talk()}\"");
        }
    }
}
using System;

namespace BOOPM3_01_11
{
    class Program
    {
        public class Panda
        {
            public string Name { get; init; }

            public Panda Partner { get; set; } = null;

            public Panda(string Name) => this.Name = Name;
            public void Marry(Panda partner)
            {
                Partner = partner;
                partner.Partner = this;
            }
        }
        static void Main(string[] args)
        {
            Panda p1 = new Panda("Bill");

            var p2 = new Panda("Anne");
            p1.Marry(p2);

            var greetings = "hello world";

            Console.WriteLine($"variable {nameof(greetings)}: {greetings}");


            //Console.WriteLine($"{p1.Name}'s class is of type {nameof(Panda)}"); // Bill's class is of type Panda
            Console.WriteLine($"{p1.Name}'s {nameof(p1.Partner)} is {p1.Partner.Name}"); // Bill's Mate is Anne
            Console.WriteLine($"{p2.Name}'s {nameof(p2.Partner)} is {p2.Partner.Name}"); // Bill's Mate is Anne

            var t = typeof(int);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.Namespace);

            Console.WriteLine("\nMethods");
            foreach (var item in t.GetMethods())
            {
                Console.WriteLine(item);
            }
 
        }
    }
}
//Excercises:
//1.    Modify class Panda to allow the property Name to be set also through object initialization.
//      Hint. Class constructor.
//2.    Create an instance of Panda using only object initialization

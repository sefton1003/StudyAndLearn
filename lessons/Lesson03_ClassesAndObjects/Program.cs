using System;
using System.Reflection.PortableExecutable;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            Character hero = new Character("Mira", 100);
            Character companion = new Character("Tavian", 80);

            hero.Speak();
            companion.Speak();

            hero.Attack(companion);

            Console.WriteLine($"{companion.Name} takes a moment to recover...");
            companion.Heal(5);

            Console.WriteLine("\nCurrent Status: ");
            hero.ShowStatus();
            companion.ShowStatus();

        }
    }
}
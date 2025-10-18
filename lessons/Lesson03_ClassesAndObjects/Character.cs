using System;

namespace Lesson03
{
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        // Constructor: runs automatically when you create a new Character
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} says: Ready for adventure!");
        }
        public void Attack(Character target)
        {
            Console.WriteLine($"{Name} attacks {target.Name}!");
            target.Health -= 10;
            Console.WriteLine($"{target.Name} now has {target.Health} health.");
        }
        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals for {amount} points and now has {Health} health.");
        }
        public void ShowStatus()
        {
            Console.WriteLine($"[{Name}]  Health: {Health}");
        }
    }
}


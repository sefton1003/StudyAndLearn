namespace Lesson03_PropertiesAndConstructors
{
    class Character
    {
        // ---------- Private backing fields ----------
        private int health;
        private int mana;

        // ---------- Public auto-properties ----------
        public string Name { get; set; }
        public int Strength { get; set; }

        // ---------- Full properties with validation ----------
        public int Health
        {
            get => health;
            set => health = value < 0 ? 0 : (value > 100 ? 100 : value);
        }

        public int Mana
        {
            get => mana;
            set => mana = value < 0 ? 0 : (value > 100 ? 100 : value);
        }

        // ---------- Constructors ----------
        // Explicit default (calls the full one)
        public Character() : this("Unknown", 10, 100, 50) { }

        // Full constructor
        public Character(string name, int strength, int health, int mana)
        {
            Name = name;
            Strength = strength;
            Health = health; // goes through property → clamps 0..100
            Mana = mana;     // goes through property → clamps 0..100
        }

        // ---------- Methods ----------
        public void TakeDamage(int amount) => Health -= amount;
        public void Heal(int amount) => Health += amount;

        public void ShowStatus()
        {
            Console.WriteLine($"{Name}: HP={Health}, MP={Mana}, STR={Strength}");
        }
    }
}

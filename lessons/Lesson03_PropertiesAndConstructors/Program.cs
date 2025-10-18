using System.Reflection.PortableExecutable;
using Lesson03_PropertiesAndConstructors;

var hero = new Character("Mira", 12, 90, 60);
var test = new Character("Tavian", 8, 150, -10);
var npc  = new Character(); // uses default constructor (chains to full)

hero.ShowStatus();
test.ShowStatus();
npc.ShowStatus();

hero.TakeDamage(200);
test.Heal(30);
npc.Heal(15);

hero.ShowStatus();
test.ShowStatus();
npc.ShowStatus();


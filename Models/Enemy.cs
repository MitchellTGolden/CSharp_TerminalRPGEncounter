using System;
namespace TerminalRPGEncounter.Models
{
    public class Enemy : IHaveStats
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        protected int health;

        public int Health
        {
            get { return health; }
        }

        public string GetInfo()
        {
            return $"{Name} is an Ally\nHealth: {Health}\nStrength: {Strength}Intelligence: {Intelligence}\nDexterity?: {Dexterity}";

        }
        public Enemy(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Enemy(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.TakeDamage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int TakeDamage(int damage)
        {
            health -= damage;
            return health;
        }
        public void getStats()
        {
            Console.WriteLine($"\n{Name}'s Stats:\nHealth: {health}\nStrength: {Strength}\nIntelligence: {Intelligence}\nDexterity: {Dexterity}\n");
        }

    }
}
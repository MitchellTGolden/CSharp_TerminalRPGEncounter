using System;

namespace TerminalRPGEncounter.Models
{
    public class Ninja : Human, IHaveStats
    {
        public Random rand = new Random();
        public Ninja(string name) : base(name)
        {
            Dexterity = 20;
        }
        public override int Attack(Enemy target)
        {
            int dmg = Dexterity * 5;
            int TwentyPercentChance = rand.Next(1, 11);
            if (TwentyPercentChance <= 2)
            {
                dmg += 10;
                Console.WriteLine("as the french say... Bonus Damage.");
            }
            target.TakeDamage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            if (target.Health <= 0)
            {
                Console.WriteLine($"{Name} has defeated {target.Name}");
            }
            return target.Health;
        }
        public int Steal(Enemy target)
        {
            int dmg = 5;
            target.TakeDamage(dmg);
            Console.WriteLine($"{Name} has stolen {dmg} health points from {target.Name}");
            TakeDamage(-dmg);

            return target.Health;
        }
    }
}
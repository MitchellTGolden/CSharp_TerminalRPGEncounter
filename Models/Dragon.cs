using System;
namespace TerminalRPGEncounter.Models
{
    public class Dragon : Enemy
    {
        public Random rand = new Random();

        public Dragon(string name) : base(name)
        {
            health = 2000;
        }
        public override int Attack(Human target)
        {
            int dmg = Strength * 10;
            int Obliteration = rand.Next(0, 11);
            if (Obliteration == 7 || Obliteration == 3)
            {
                Console.Write($"{Name} titters to himself, this ones going to hurt!");
                dmg = target.Health;
            }
            target.TakeDamage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            if (target.Health <= 0)
            {
                Console.WriteLine($"{Name} has defeated {target.Name}");
            }
            return target.Health;
        }
    }

}
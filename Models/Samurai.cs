using System;
namespace TerminalRPGEncounter.Models
{
    public class Samurai : Human
    {
        public Random rand = new Random();

        public Samurai(string name) : base(name)
        {
            health = 200;
        }
        public override int Attack(Enemy target)
        {
            int dmg = Strength * 3;
            if (target.Health <= 50)
            {
                int roll = rand.Next(1, 10);
                if (roll >= 1 && roll <= 3)
                {
                    Console.WriteLine($"{Name} tells {target.Name}: I noticed your current health is {target.Health}, let me finish you off.\n");
                }
                if (roll > 3 && roll <= 6)
                {
                    Console.WriteLine($"{Name} tells {target.Name}: You call that CSS!! HAH.\n");
                }
                if (roll > 6 && roll <= 9)
                {
                    Console.WriteLine($"{Name} tells {target.Name}: Now you'll never beat me in Sketchful.io.\n");
                }
                dmg = target.Health;
                target.TakeDamage(dmg);

            }
            else
            {
                target.TakeDamage(dmg);
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            if (target.Health <= 0)
            {
                Console.WriteLine($"{Name} has defeated {target.Name}");
            }
            return target.Health;
        }
        public int Meditate()
        {
            int heal = 200 - health;
            health += heal;
            Console.WriteLine($"{Name} has healed for {heal} and is now back at a full health");
            return health;
        }
    }
}
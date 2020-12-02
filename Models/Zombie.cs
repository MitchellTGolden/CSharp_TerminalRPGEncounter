using System;
namespace TerminalRPGEncounter.Models
{
        public class Zombie : Enemy
        {
            public Zombie(string name) : base(name)
            {
                Intelligence = 50;
                health = 500;
            }
            public override int Attack(Human target)
            {
                int dmg = Strength * 6;
                if (health < 50)
                {
                    health += dmg;
                    if (health > 50)
                    {
                        int over = health - 50;
                        health -= over;
                    }
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

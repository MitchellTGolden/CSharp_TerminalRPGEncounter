using System;

namespace TerminalRPGEncounter.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }
        public override int Attack(Enemy target)
        {
            int dmg = Intelligence * 5;
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
        public int Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.TakeDamage(heal * -1);
            Console.WriteLine($"{Name} has healed {target.Name} for {heal}");
            return target.Health;
        }
    }
}
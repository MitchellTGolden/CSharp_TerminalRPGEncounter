using System;
using System.Collections.Generic;
using System.Linq;

namespace TerminalRPGEncounter.Models
{
    public static class Battle
    {

        static Random rand = new Random();

        public static void B(List<Human> l1, List<Enemy> l2, List<Enemy> l3, List<Human> l4)
        {

            while (!l1.All(a => a.Health <= 0) && l1.Count > 0 && l2.Count > 0 || !l2.All(a => a.Health <= 0) && l1.Count > 0 && l2.Count > 0)
            {
                if (l1.Count > 0 && l2.Count != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\nAllies:\n");

                    foreach (var ally in l1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        int whichEnemy = rand.Next(0, l2.Count);
                        // ally.getStats();
                        if (l2.Count > 0 && ally.Health > 0)
                        {
                            ally.Attack(l2[whichEnemy]);
                            if (l2[whichEnemy].Health <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;

                                Console.WriteLine($"\n{l2[whichEnemy].Name} was added to the army of the dead.\n");
                                l3.Add(l2[whichEnemy]);
                                l2.Remove(l2[whichEnemy]);
                                Console.ResetColor();

                            }
                        }

                    }
                    Console.ResetColor();

                }
                if (l1.Count != 0 && l2.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.Write("\nEnemies:\n");
                    foreach (var enemy in l2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        int whichAlly = rand.Next(0, l1.Count);
                        // enemy.getStats();
                        if (l1.Count > 0 && enemy.Health > 0)
                        {
                            enemy.Attack(l1[whichAlly]);
                            if (l1[whichAlly].Health <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"\n{l1[whichAlly].Name} was added to the army of the dead.\n");
                                l4.Add(l1[whichAlly]);
                                l1.Remove(l1[whichAlly]);
                                Console.ResetColor();
                            }
                        }
                    }
                    Console.ResetColor();

                }
            }
        }
        public static void post1(List<Human> l1, List<Enemy> l2, List<Enemy> l3, List<Human> l4)
        {

            Console.WriteLine("\nThe battle has finished..");
            if (l4.Count > 0)
            {
                Console.WriteLine("Fatalities for the allies include:");
                foreach (var DeadAlly in l4)
                {
                    Console.WriteLine($"{DeadAlly.Name}");
                }
            }
            if (l4.Count == 0)
            {
                Console.WriteLine("Surprisingly no allies have died.");
            }
            if (l3.Count > 0)
            {
                Console.WriteLine("Fatalities for the enemies include:");
                foreach (var DeadEnemy in l3)
                {
                    Console.WriteLine($"{DeadEnemy.Name}");
                }
            }
            if (l3.Count == 0)
            {
                Console.WriteLine("How embarrassing. You didn't manage to kill a single Enemy!");
            }
            if (l1.Count == 0)
            {
                Console.WriteLine("\nAll Allies have been slain.\n\nGame over. Type `dotnet run` to play again");
            }
            if (l1.Count > 0)
            {
                Console.WriteLine($"You made it through the first stage with {l1.Count} allies remaining!\n\nTo check current stats and proceed type 1.");
                string proceed1 = Console.ReadLine();
                while (proceed1 != "1")
                {
                    Console.WriteLine("Just press 1, why drag your death out any further.");
                    proceed1 = Console.ReadLine();
                }

                if (proceed1 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    foreach (var Ally in l1)
                    {
                        Console.WriteLine($"{Ally.Name} has {Ally.Health} Health remaining.");
                    }
                    Console.ResetColor();

                }
            }
        }
        public static void post2(List<Human> l1, List<Enemy> l2, List<Enemy> l3, List<Human> l4, List<Enemy> l5)
        {
            Console.WriteLine("\nThe battle has finished..");
            if (l4.Count > 0)
            {
                Console.WriteLine("Fatalities for the allies include:");
                foreach (var DeadAlly in l4)
                {
                    Console.WriteLine($"{DeadAlly.Name}");
                }
            }
            if (l4.Count == 0)
            {
                Console.WriteLine("Surprisingly no allies have died.");
            }
            if (l3.Count > 0)
            {
                Console.WriteLine("Fatalities for the enemies include:");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                foreach (var DeadEnemy in l3)
                {
                    Console.WriteLine($"{DeadEnemy.Name}");
                }
                Console.ResetColor();
            }
            if (l3.Count == 0)
            {
                Console.WriteLine("How embarrassing. You didn't manage to kill a single Enemy!");
            }
            if (l1.Count == 0)
            {
                Console.WriteLine("\n\n\nGame over. Type `dotnet run` to play again");
                return;
            }
            if (l1.Count > 0)
            {
                Console.WriteLine($"You made it through the Second stage with {l1.Count} allies remaining!\n\nTo check current stats and proceed type 1.");
                string proceed1 = Console.ReadLine();
                while (proceed1 != "1")
                {
                    Console.WriteLine("Why would you go off script when you're already this far in?");
                    proceed1 = Console.ReadLine();
                }

                if (proceed1 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"The K/D Ratio of this group is:  {l3.Count + l5.Count} : {l4.Count}");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    foreach (var Ally in l1)
                    {
                        Console.WriteLine($"{Ally.Name} has {Ally.Health} Health remaining.");
                    }
                    Console.ResetColor();

                }
            }
        }
        
    }
}
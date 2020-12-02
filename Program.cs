using System;
using System.Collections.Generic;
using TerminalRPGEncounter.Models;
using System.Linq;

namespace TerminalRPGEncounter
{
    class Program
    {
        static Random rand = new Random();
        public static List<Human> Allies = new List<Human>();
        public static List<Human> DeadAllies = new List<Human>();

        public static List<Enemy> Enemies = new List<Enemy>(){
            new Spider("Itsy Bitsy"),
            new Zombie("Rob"),
            new Zombie("Magnets"),
        };
        public static List<Enemy> EnemiesVTwo = new List<Enemy>(){
            new Spider("Itsy Bitsy2.0"),
            new Zombie("Rob2.0"),
            new Zombie("Magnets2.0"),
        };
        public static List<Enemy> EnemiesVThree = new List<Enemy>(){
            new Dragon("Smaug"),
            };

        public static List<Enemy> DeadEnemies = new List<Enemy>();
        public static List<Enemy> DeadEnemiesV2 = new List<Enemy>();
        public static void ListAllies(List<Human> Team)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            foreach (var ally in Team)
            {
                Console.WriteLine($"{ally.Name}");
            }
            Console.ResetColor();

        }
        public static void ListEnemies(List<Enemy> Team)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            foreach (var enemy in Team)
            {
                Console.WriteLine($"{enemy.Name}");
            }
            Console.ResetColor();

        }
        static void Main(string[] args)
        {
            CreateTeam.Begin(Allies);
            Console.WriteLine("\nLet's begin.\n");
            Console.WriteLine("You immediatley see a fork in the road (the decisions are now in your hands).");
            Console.WriteLine("\nPress 1 to Flip a coin to take a shortcut.\nOr any other key to take the *dangerous* route.\n");
            string intToFlip = Console.ReadLine();
            Flip.CoinFlip(intToFlip);
            string firstEncounter = Console.ReadLine();
            if (firstEncounter == "1")
            {
                Console.WriteLine($"You approach cautiously, but {Allies[0].Name} shrieks.\nYou've been spotted.");
            }
            else
            {
                Console.WriteLine($"You turn around to try to flee, but {Allies[0].Name} shrieks.\nThe Enemies have teleported and stopped you dead in your tracks.");
            }
            Console.WriteLine("Our first battle, how exciting.\n\n");
            ListAllies(Allies);
            Console.WriteLine("\nVS\n");
            ListEnemies(Enemies);
            Console.WriteLine("\nLet the battle begin.\ny/n?");
            string PauseForDramaticEffect = Console.ReadLine();
            Battle.B(Allies, Enemies, DeadEnemies, DeadAllies);
            Battle.post1(Allies, Enemies, DeadEnemies, DeadAllies);
            if (Allies.Count > 0)
            {
                Console.WriteLine("Let's Proceed.");
                Console.WriteLine($"After a short recovery\nThe group proceeds down the path to find a trail blood.\n{Allies[0].Name} says: This seems like something out of Hansel and Gretel.\nAt the end of the bloody rainbow you squint and rub your eyes.\n{Allies[0].Name} whispers: Isn't that {DeadEnemies[0].Name}, {DeadEnemies[1].Name}, and {DeadEnemies[2].Name}?\nDidn't we just kill them?\n y/n?");
            }
            else
            {
                return;
            }
            string acknowlegeTheFlavorText = Console.ReadLine();
            Console.WriteLine("As a collective: Or so we thought.");
            Console.WriteLine("\nBattle after DARK!.... DARk... DArk.. Dark. dark....***Air Horns Blaring***\nStanding in the Blue Corner we have:");
            ListAllies(Allies);
            Console.WriteLine("\nAnd in the Red Corner:");
            ListEnemies(EnemiesVTwo);
            Console.WriteLine("\nStart the next round?\ny/n?\n");
            string acknowlegeTheFlavorText2 = Console.ReadLine();
            Console.WriteLine("Let the battle begin.\n\n");
            Battle.B(Allies, EnemiesVTwo, DeadEnemiesV2, DeadAllies);
            Battle.post2(Allies, Enemies, DeadEnemiesV2, DeadAllies, DeadEnemies);
            Console.WriteLine($"{Allies[0].Name}: We're alive..");
            Console.WriteLine($"{Allies[0].Name}: Should we continue?\ny/n?");
            string FlavorTextisLife = Console.ReadLine();
            Console.WriteLine($"\nCovered in Zombie and Spider guts the party tredges along.\n");
            Console.WriteLine($"\nWOOSH!");
            Console.WriteLine($"{Allies[0].Name}: Did you hear that?\ny/n?");
            string PauseForDramaticEffect2 = Console.ReadLine();
            Console.WriteLine($"\nWOOSH!\n*LOUD flapping sounds above your head*");
            Console.WriteLine($"{Allies[0].Name}: I can't be the only one hearing this!\nRight?(y/n)");
            string PauseForDramaticEffect3 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{EnemiesVThree[0].Name}: So you've made it to end.\n{EnemiesVThree[0].Name}: Let's see if you can get though me!");
            Console.ResetColor();
            Console.WriteLine("See the lineup(y/n)\n");
            string PauseForDramaticEffect4 = Console.ReadLine();
            Console.WriteLine("\n\nThese are the Allies still in the fight.\n");
            ListAllies(Allies);
            Console.WriteLine($"\nVS\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\n{EnemiesVThree[0].Name} the Undefeated, Human-eating, Bone-crunching, Blood-sucking Dragon from Adrien Dion's Elven North Pole!!!\n");
            Console.ResetColor();
            Console.WriteLine($"{Allies[0].Name}: Really... The North Pole?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{EnemiesVThree[0].Name}: Hell I didn't write the script. \n{EnemiesVThree[0].Name}: There's {Allies.Count} of you and only one of me. Are we going to fight or what?");
            Console.ResetColor();
            Console.WriteLine("Initiate Battle(y/n)");
            string GottaLoveSomeFlavorText = Console.ReadLine();
            Console.WriteLine("Final Battle Scene Coming in Part Deux...");
        }
    }
}
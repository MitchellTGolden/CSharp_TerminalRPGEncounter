using System;
using System.Collections.Generic;
using TerminalRPGEncounter.Models;
using System.Linq;
namespace TerminalRPGEncounter.Models
{
    public class CreateTeam
    {
        public static void Begin(List<Human> Allies)
        {
            Console.WriteLine("\n\n\n\n\n\nWelcome, weary traveller");
            Console.WriteLine("This is supposed to be a three player game (allegedly), but if you would like to add more or less please type now or forever hold your peace.\n");
            Console.WriteLine("Enter a value of how many allies you would like (1-3) or if you're feeling upto it type a 0");
            int numOfAllies = Convert.ToInt32(Console.ReadLine());
            while ((numOfAllies > 3 || numOfAllies < 0))
            {
                Console.WriteLine("Well someone can't read.. Let's try this again.. Enter a number 0-3");
                numOfAllies = Convert.ToInt32(Console.ReadLine());
            }
            if (numOfAllies > 1 && numOfAllies <= 3)
            {
                Console.WriteLine($"You've chosen to have {numOfAllies} join you in this grueling quest. 1(you) + {numOfAllies}(allies) = {1 + numOfAllies}(Allies that will fight to determine their fate.) MATH!");
            }
            if (numOfAllies == 0)
            {
                Console.WriteLine("I've underestimated you.. *In a duke nukem voice* YOU'VE GOT BALLS OF STEEL!");
            }
            if (numOfAllies == 1)
            {
                Console.WriteLine($"\n\nYou've chosen to have only {numOfAllies} ally to join you. \n*Bill Withers soulfully singing* \nJust the two of us, We can make it if we try, Just the two of us... You and I");
            }

            for (var i = 0; i < numOfAllies + 1; i++)
            {
                Console.WriteLine($"What shall we call you player {i + 1}?");
                string inputName = Console.ReadLine();
                while (inputName.Length < 2)
                {
                    if (inputName.Length < 2 && inputName.Length > 0)
                    {
                        Console.WriteLine($"Alright {inputName}(this is what you typed in): Humor me... name one person you know with a 1 letter name... \nOR, input your actual name");
                        inputName = Console.ReadLine();
                    }

                    if (inputName.Length == 0)
                    {
                        Console.WriteLine("Hmmm. We got a wise guy here ladies and genetleman.Alright Mr(s). No Name.. Name one person without a name.... Get it? It's not possible.\nTry again: Input your NAME");
                        inputName = Console.ReadLine();
                    }
                }
                Console.WriteLine($"Welcome, {inputName}");
                Console.WriteLine($"{inputName} Please type the number of the class you would like to embody.\n1 : Wizard\n2 : Ninja\n3 : Samurai");
                int classChoice = Convert.ToInt32(Console.ReadLine());
                switch (classChoice, i)
                {
                    case (1, 0):
                        Console.WriteLine("You have chose Wizard");
                        Wizard w0 = new Wizard($"{inputName}");
                        Allies.Add(w0);
                        break;
                    case (2, 0):
                        Console.WriteLine("You have chosen Ninja");
                        Ninja n0 = new Ninja($"{inputName}");
                        Allies.Add(n0);
                        break;
                    case (3, 0):
                        Console.WriteLine("You have chosen Samurai");
                        Samurai s0 = new Samurai($"{inputName}");
                        Allies.Add(s0);
                        break;
                    case (1, 1):
                        Console.WriteLine("You have chose Wizard");
                        Wizard w1 = new Wizard($"{inputName}");
                        Allies.Add(w1);
                        break;
                    case (2, 1):
                        Console.WriteLine("You have chosen Ninja");
                        Ninja n1 = new Ninja($"{inputName}");
                        Allies.Add(n1);
                        break;
                    case (3, 1):
                        Console.WriteLine("You have chosen Samurai");
                        Samurai s1 = new Samurai($"{inputName}");
                        Allies.Add(s1);
                        break;
                    case (1, 2):
                        Console.WriteLine("You have chose Wizard");
                        Wizard w2 = new Wizard($"{inputName}");
                        Allies.Add(w2);
                        break;
                    case (2, 2):
                        Console.WriteLine("You have chosen Ninja");
                        Ninja n2 = new Ninja($"{inputName}");
                        Allies.Add(n2);
                        break;
                    case (3, 2):
                        Console.WriteLine("You have chosen Samurai");
                        Samurai s2 = new Samurai($"{inputName}");
                        Allies.Add(s2);
                        break;
                    case (1, 3):
                        Console.WriteLine("You have chose Wizard");
                        Wizard w3 = new Wizard($"{inputName}");
                        Allies.Add(w3);
                        break;
                    case (2, 3):
                        Console.WriteLine("You have chosen Ninja");
                        Ninja n3 = new Ninja($"{inputName}");
                        Allies.Add(n3);
                        break;
                    case (3, 3):
                        Console.WriteLine("You have chosen Samurai");
                        Samurai s3 = new Samurai($"{inputName}");
                        Allies.Add(s3);
                        break;
                };
                if (numOfAllies != i)
                {
                    Console.WriteLine("\nNext victim, I meant next ally! \n");
                }
            }
            Console.WriteLine("This is your team... Looking at the lineup. All I have to say is goodluck.");
            foreach (var ally in Allies)
            {
                Console.WriteLine($"{ally.Name}");
            }
            Console.WriteLine("If you want to see your team's stats: enter 1, otherwise enter any key");
            string GetTeamStats = Console.ReadLine();
            if (GetTeamStats == "1")
            {
                foreach (var ally in Allies)
                {
                    ally.getStats();
                }
            }
        }
    }
}
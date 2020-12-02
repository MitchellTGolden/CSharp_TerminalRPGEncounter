using System;
using System.Collections.Generic;
using TerminalRPGEncounter.Models;
using System.Linq;
namespace TerminalRPGEncounter.Models
{
    public class Flip
    {
                static Random rand = new Random();

        public static void CoinFlip(string intToFlip)
        {
            if (intToFlip == "1")
            {
                int coinFlip = rand.Next(0, 2);
                Console.WriteLine("\nCall it in the air.\n1:Tails\nNot 1: Heads\n");
                string CallIt = Console.ReadLine();
                if (CallIt == "1")
                {
                    Console.WriteLine("\nYou called: Heads");
                }
                else
                {
                    Console.WriteLine("\nYou called: Tails");
                }


                if (coinFlip == 1)
                {
                    string heads = "Heads";
                    Console.WriteLine($"\nIt landed on {heads}");
                }
                else
                {
                    string tails = "Tails";
                    Console.WriteLine($"\nIt landed on {tails}");
                }

                if (CallIt == "1" && coinFlip == 1)
                {
                    Console.WriteLine("\nWow, Nice job. Magically the fork in the road dissipates, and the only path is the dangerous route.\nInteresting.. You managed to hit the coin flip for nothing.");
                }
                if (CallIt != "1" && coinFlip != 1)
                {
                    Console.WriteLine("\nWow, Nice job. Magically the fork in the road dissipates, and the only path is the dangerous route.\nInteresting.. You managed to hit the coin flip for nothing.");
                }
                if (CallIt == "1" && coinFlip != 1)
                {
                    Console.WriteLine("\nBetter Luck next time. Dangerous route it is.");
                }
                if (CallIt != "1" && coinFlip == 1)
                {
                    Console.WriteLine("\nBetter Luck next time. Dangerous route it is.");
                }
            }
            else
            {
                intToFlip = "0";
            }
            if (intToFlip == "1")
            {
                Console.WriteLine("\n\n\nConfused by what just happened\nYou proceed to take a few steps down the dark wooded trail and hear rustling each side of you.\n1: Approach cautiously\nAny other key: Vigorously Flee(They have your scent. They'll catchup by the next prompt.)");
            }
            if (intToFlip == "0")
            {
                Console.WriteLine("\n\n\nYou proceed to take a few steps down the dark wooded trail and hear rustling each side of you.\n1: Approach cautiously\nAny other key: Vigorously Flee(They have your scent. They will catchup by the next prompt.)");
            }
        }
    }
}
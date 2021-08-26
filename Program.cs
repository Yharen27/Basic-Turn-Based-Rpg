using System;
namespace Text_Based_Rpg
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Text Based Rpg";   
            Console.WriteLine("You are tasked by the king to vanquished a ferocious dragon. -- Press Enter to continue dialog --");
            pressEnter();
            Console.WriteLine("You ventured deep into the dragon's lair.");
            pressEnter();
            Console.WriteLine("Suddenly the dragon wakes from its deep slumber and finds you.");
            pressEnter();
            gameLoop();  
        }
        static void gameLoop() // Loops through until player or dragon's hp is less than or equal to 0
        {
            while (Stats.playerHp > 0 && Stats.dragonHp > 0)
            {
                gameSequence();
                if (Stats.dragonHp <= 0)
                {
                    playerVictory();
                }
                else if (Stats.playerHp <= 0)
                {
                    playerDefeat();
                }
            }
        }
        static void gameSequence()
        {
            Console.WriteLine("What do you do?");
            Console.WriteLine("1.Attack\n2.Heal\n3.Defend\n4.Nothing\n5.Quit\nType the word or number");
            string playerChoice = Convert.ToString(Console.ReadLine()); // Gets input from player
            if (playerChoice == "Attack" || playerChoice == "1")
            {
                attackChoice();
            }
            else if (playerChoice == "Heal" || playerChoice == "2")
            {
                healChoice();
            }
            else if (playerChoice == "Defend" || playerChoice == "3")
            {
                defendChoice();
            }
            else if (playerChoice == "Nothing" || playerChoice == "4")
            {
                nothingChoice();
            }
            else if (playerChoice == "Quit" || playerChoice == "5")
            {
                quitGame();
            }
        }
        // Choices
        static void attackChoice()
        {
            Console.WriteLine("You attacked and dealt "+Stats.playerDmg+"dmg!");
            Stats.dragonHp -= Stats.playerDmg;
            Console.WriteLine($"Dragon has {Stats.dragonHp} hp left");
            pressEnter();
            dragonAttack();
            gameLoop();
        }
        static void healChoice()
        {
            Console.WriteLine("You healed yourself and got "+Stats.playerHeal+"hp.");
            Stats.playerHp += Stats.playerHeal;
            Console.WriteLine($"Player has {Stats.playerHp} hp left");
            pressEnter();
            dragonAttack();
            gameLoop();
        }
        static void defendChoice()
        {
            Console.WriteLine("You blocked the dragon's attack");
            pressEnter();
            gameLoop();
        }
        static void nothingChoice()
        {
            Console.WriteLine("You did nothing to the dragon's attack.");
            pressEnter();
            dragonAttack();
            gameLoop();
        }
        static void dragonAttack()
        {
            Console.WriteLine("The dragon attacked and dealt "+Stats.dragonDmg+"dmg!");
            Stats.playerHp -= Stats.dragonDmg;
            Console.WriteLine($"Player has {Stats.playerHp} hp left");
            gameLoop();
        }
        static void playerVictory()
        {
            Console.WriteLine("You've won and vanquished the dragon");
            resetStats();
            pressEnter();
            Main();
        }
        static void playerDefeat()
        {
            Console.WriteLine("You died");
            resetStats();
            pressEnter();
            Main();
        }
        static void pressEnter()
        {
            Console.ReadKey();
        }
        static void resetStats()
        {
            Stats.playerHp = 100;
            Stats.playerDmg = Stats.numberGen.Next(20,40);
            Stats.playerHeal = Stats.numberGen.Next(30,50);
            Stats.dragonHp = 200;
            Stats.dragonDmg = Stats.numberGen.Next(30,50);
        }
        static void quitGame()
        {
            System.Environment.Exit(0);
        }
    }
}
// Hm

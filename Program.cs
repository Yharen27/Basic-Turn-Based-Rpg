using System;
namespace Text_Based_Rpg
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("You are tasked by the king to vanquished a ferocious dragon.");
            Console.ReadKey();
            Console.WriteLine("You ventured deep into the dragon's lair.");
            Console.ReadKey();
            Console.WriteLine("Suddenly the dragon wakes from its deep slumber and finds you.");
            Console.ReadKey();
            gameLoop();   
        }
        static void gameLoop()
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
            Console.ReadKey();
            Console.WriteLine("1.Attack\n2.Heal\n3.Defend\n4.Nothing");
            string playerChoice = Console.ReadLine();
            if (playerChoice == "Attack")
            {
                attackChoice();
            }
            else if (playerChoice == "Defend")
            {
                defendChoice();
            }
            else if (playerChoice == "Heal")
            {
                healChoice();
            }
            else if (playerChoice == "Nothing")
            {
                nothingChoice();
            }
        }
        static void attackChoice()
        {
            Console.WriteLine("Player has "+Stats.playerHp+"hp and Dragon has "+Stats.dragonHp+"hp.");
            Console.ReadKey();
            Console.WriteLine("You attacked and dealt "+Stats.playerDmg+"dmg!");
            Stats.dragonHp -= Stats.playerDmg;
            Console.ReadKey();
            dragonAttack();
            Console.ReadKey();
            gameLoop();
        }
        static void healChoice()
        {
            Console.WriteLine("Player has "+Stats.playerHp+"hp and Dragon has "+Stats.dragonHp+"hp.");
            Console.ReadKey();
            dragonAttack();
            Console.ReadKey();
            Console.WriteLine("You healed yourself and got "+Stats.playerHeal+"hp.");
            Stats.playerHp += Stats.playerHeal;
            Console.ReadKey();
            gameLoop();
        }
        static void defendChoice()
        {
            Console.WriteLine("Player has "+Stats.playerHp+"hp and Dragon has "+Stats.dragonHp+"hp.");
            Console.ReadKey();
            Console.WriteLine("You blocked the dragon's attack");
            Console.ReadKey();
            gameLoop();
        }
        static void nothingChoice()
        {
            Console.WriteLine("Player has "+Stats.playerHp+"hp and Dragon has "+Stats.dragonHp+"hp.");
            Console.ReadKey();
            Console.WriteLine("You did nothing to the dragon's attack.");
            Console.ReadKey();
            gameLoop();
        }
        static void dragonAttack()
        {
            Console.WriteLine("Player has "+Stats.playerHp+"hp and Dragon has "+Stats.dragonHp+"hp.");
            Console.ReadKey();
            Console.WriteLine("The dragon attacked and dealt "+Stats.dragonDmg+"dmg!");
            Stats.playerHp -= Stats.dragonDmg;
            Console.ReadKey();
            gameLoop();
        }
        static void playerVictory()
        {
            Console.WriteLine("You've won and vanquished the dragon");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
        static void playerDefeat()
        {
            Console.WriteLine("You died");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
    }
}
using System;
using System.Collections.Generic;
namespace Text_Based_Rpg
{
    class Stats
    {
        // Stats of Player & Dragon
        static Random numberGen = new Random();
        public static int playerHp = 100;
        public static int playerDmg = numberGen.Next(20,40);
        public static int playerHeal = numberGen.Next(30,50);
        public static int dragonHp = 200;
        public static int dragonDmg = numberGen.Next(30,50);
    }
}
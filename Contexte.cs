using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique
{
    public static class Contexte
    {
        public static int Score {  get; private set; }
        public static int life;

        public static void AddScore(int points)
        {
            Score += points;
        }

        static Contexte()
        {
            Score = 0;
            life = 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw13
{
    internal class LINQ
    {
        public static void run()
        {
            int[] scores = new int[] { 3, 6, 1, 8, 12 };
            int goodscore = 6;
            IEnumerable<int> query = 
                from score in scores
                where score > goodscore
                select score;
            foreach (int score in query)
            {
                Console.WriteLine(score);
            }
        }
    }
}

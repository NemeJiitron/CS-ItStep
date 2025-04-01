using System;
using System.Text;
using project2.hm;
using project2.hm.HM_4;
using static project2.hm.hm_1;
using static project2.hm.hm_2;
using static project2.hm.hm_3;
using static project2.hm.HM_4.BookList;
using static project2.hm.HM_4.TemperatureArray;
using static project2.hm.HM_4.Fraction;
using static project2.hm.HM_6.Money;
using static project2.hm.HM_5.Course;
using static project2.hm.HM_5.OnlineCourse;
using project2.hm.HM_5;
using project2.hm.HM_6;
using project2.hm.HM_8;
using ClassWork.CW.cw7;
using project2.hm.HM_9;
using project2.hm.HM_10;
using project2.hm.HM_11;
using project2.hm.HM_12;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //          1
            List<Poem> poems = new List<Poem>();
            poems.Add(new Poem());
            poems.Add(new Poem());
            poems.Add(new Poem());
            Console.WriteLine(Poem.SearchBy(poems, "name", "name").ToString());
            using(StreamWriter sw = new StreamWriter("Poems.txt"))
            {
                foreach (Poem poem in poems) sw.WriteLine(poem.ToString());
            }
            List<Poem> poems2 = new List<Poem>();
            using (StreamReader sr = new StreamReader("Poems.txt"))
            {
                while(!sr.EndOfStream)
                {
                    poems2.Add(new Poem(sr.ReadLine(), sr.ReadLine(), int.Parse(sr.ReadLine()), sr.ReadLine(), sr.ReadLine()));
                    sr.ReadLine();
                }
            }
            foreach (Poem poem in poems2)
            {
                Console.WriteLine(poem.ToString());
            }



        }

    }
}

using System;
using System.Text;
//using project2.hm;
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
using project2.hm.HM_13;
using project2.HM_14;
using System.Text.Json;

namespace project2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        //              1
            //List<Frac> fracs = new List<Frac>();
            //int d = 1;
            //while(d != 0)
            //{
            //    fracs.Add(Frac.Read());
            //    d = fracs.Last().Denominator;
            //}
            //fracs.RemoveAt(fracs.Count - 1);
            //SerializerJson.Save(fracs, "Fractures.json");
            //List<Frac> fracs2 = SerializerJson.Load<List<Frac>>("Fractures.json");
            //foreach(Frac f in fracs2)
            //{
            //    Console.WriteLine($"{f.Numerator}\n-\n{f.Denominator}");
            //    Console.WriteLine();
            //}
        //              2/3/4
            Journal journal = new Journal("Minoni", "Knyazin house", "02-02-2025", 10000, new Article[2] { new Article("Ballhog", 100, "Knyzin fr ballhog"), new Article("Kyrie Ballhog", 111100, "tomu sho win goat") });
            Console.WriteLine(journal);
            SerializerJson.Save(journal, "journal.json");
            Journal journal2 = SerializerJson.Load<Journal>("journal.json");
            Console.WriteLine(journal2);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Journal journal3 = new Journal("Nords", "ling.drk", "02-02-2025", 1200, new Article[2] { new Article("runes", 100, "runic alphabet"), new Article("onthology", 111100, "turk is tsar") });
            Journal[] journals = new Journal[2] { journal, journal3 };
            SerializerJson.Save(journals, "journals.json");
            Journal[] journals2 = SerializerJson.Load<Journal[]>("journals.json");
            foreach(Journal j in journals2)
            {
                Console.WriteLine(j);
            }
        }


    }
}

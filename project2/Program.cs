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

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack backpack = new("red", "brand", "leather", 2, 5);
            backpack.OnItemAdded += (obj) =>
            {
                Console.WriteLine($"Item {obj.ToString} is put in backpack");
            };
            backpack.OnItemRemoved += (obj) =>
            {
                Console.WriteLine($"Item {obj.ToString} is removed from backpack");
            };
            backpack.OnVarChanged += () =>
            {
                Console.WriteLine($"Var changed");
            };
            CreditCardDelegates.main();


        }

    }
}

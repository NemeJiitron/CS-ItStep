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

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hm.HM_6.Money money = new(100, 0);
            try
            {
                money.Print();
                money = money - new hm.HM_6.Money(20, 50);
                money.Print();
                money += new hm.HM_6.Money(35, 25);
                money.Print();
                money -= new hm.HM_6.Money(110, 50);
                money.Print();
                money -= new hm.HM_6.Money(4, 26);

            }
            catch (BankrutException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}

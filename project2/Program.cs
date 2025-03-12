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
using ClassWork.CW.cw7;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray();
            array.Show();
            Console.WriteLine(array.Greater(50));
            Console.WriteLine(array.Less(50));
            array.ShowEven();
            array.ShowOdd();
            Console.WriteLine(array.CountDistinct());
            Console.WriteLine(array.EqualToValue(50));

        }

    }
}

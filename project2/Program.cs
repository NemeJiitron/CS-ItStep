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
using static project2.hm.HM_5.Money;
using static project2.hm.HM_5.Course;
using static project2.hm.HM_5.OnlineCourse;
using project2.hm.HM_5;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Money money = new(100, 250);
            //money.Print();
            //money.Add(15, 69);
            //money.Print();
            //hm.HM_5.Product prod = new("zhivchik",100, 250);
            //prod.Print();
            //prod.Add(15, 69);
            //prod.Print();
            //prod.Sub(50, 49);
            //prod.Print();
            //Course course = new("Managment", "12 month");
            //OnlineCourse onCourse = new("Managment", "12 month", "litosphere");
            //Console.WriteLine(course.ToString());
            //Console.WriteLine(onCourse.ToString());
            Product2[] product2s = { new Electronics(), new Furniture(), new Furniture(), new Electronics() };
            foreach (Product2 product in product2s) 
            {
                product.CalculateDiscount();
            }
        }

    }
}

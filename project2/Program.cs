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

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Library library = new Library(new Book("A", "b", "d", 420), new Book("d", "b", "d", 104), new Book("a", "b", "q", 1200)))
            {
                Console.WriteLine(library.ToString());
                library.Books[0].CreateGarbage();
                System.GC.Collect();
            }
            using (hm.HM_8.File file = new hm.HM_8.File(".txt", 240, "\\C\\itstep\\.NET"))
            {
                Console.WriteLine(file.ToString());
                file.CreateGarbage();
                System.GC.Collect();
            }

        }

    }
}

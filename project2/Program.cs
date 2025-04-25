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
using project2.HM_16;
using project2.Exam_Practice.DictApp;

namespace project2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DictionariesApp program = new DictionariesApp("SavedDicts.json");
            program.Run();
        }


    }
}

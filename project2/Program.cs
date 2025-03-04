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

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BookList bookList = new BookList();
            //bookList += "The Witcher: Last wish";
            //bookList += "The Witcher: Sword of destiny";
            //bookList += "The Witcher: Wild hunt";
            //bookList.Print();
            //bookList.Erase(1);
            //bookList.Print();
            //bookList[0] = "Peppa pig";
            //Console.WriteLine(bookList[0]);
            //TemperatureArray tempArr = new TemperatureArray();
            //tempArr[0] = 15;
            //tempArr[1] = 10;
            //tempArr[2] = 17;
            //tempArr[3] = 20;
            //tempArr[4] = 12;
            //tempArr[5] = 22;
            //tempArr[6] = 18;
            //Console.WriteLine(tempArr.Average());
            Fraction fr1 = new(4, 5);
            Fraction fr2 = new(4, 12);
            Fraction fr3 = fr1 + fr2;
            fr3.print();

            Fraction fr4 = fr1 - fr2;
            fr4.print();
            Fraction fr5 = fr1 * fr2;
            fr5.print();
            Fraction fr6 = fr1 / fr2;
            fr6.print();
        }

    }
}

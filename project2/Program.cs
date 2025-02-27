using System;
using System.Text;
using project2.hm;
using static project2.hm.hm_1;
using static project2.hm.hm_2;
using static project2.hm.hm_3;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hm_3.Square(10, '@');
            //Console.WriteLine(hm_3.IsPalindrom(45654));

            //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] ints2 = { 3, 4, 7, 8 };
            //int[] ints3 = hm_3.Filter(ints, ints2);
            //for (int i = 0; i < ints3.Length; i++)
            //{
            //    Console.Write(ints3[i] + " ");
            //}

            Tank tank = new(20, "Wood", false);
            tank.PrintValues();
            tank.Fill();
            tank.PrintValues();
        }
    }
}

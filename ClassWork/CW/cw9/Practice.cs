using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project2.hm.HM_9;

namespace ClassWork.CW.cw9
{
    #region Part 1
    internal class MyDelegate
    {

        public delegate double BinaryDel(double x, double y);
        public delegate string IsEven(int x);
        public delegate bool IsWeekend(string day);
        public delegate int MaxMin(int[] arr);
        public delegate int[] Filter(int[] arr);
    }
    internal class Practice
    {
        public static void Run()
        {

            MyDelegate.IsEven isEven = delegate (int x)
            {
                if (x % 2 == 0)
                {
                    return "Even";
                }
                else
                {
                    return "Odd";
                }
            };
            Console.WriteLine(isEven(6));

            MyDelegate.BinaryDel Power = delegate (double x, double y)
            {
                return Math.Pow(x, y);
            };
            Console.WriteLine(Power(3, 3));

            MyDelegate.BinaryDel Power2 = (double x, double y) =>
            {
                return Math.Pow(x, y);
            };
            Console.WriteLine(Power2(3, 3));

            MyDelegate.IsWeekend isWikend = (string day) =>
            {
                return day == "Saturday" || day == "Sunday";
            };
            Console.WriteLine(isWikend("Sunday"));

            MyDelegate.MaxMin max = (int[] arr) =>
            {
                int max = arr[0];
                int index = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        index = i;
                    }
                }
                Console.WriteLine($"Max - {max}; Index - {index}");
                return max;
            };
            max(new int[] { 1, 6, 2, 9, 12, 4, 8 });

            MyDelegate.MaxMin min = (int[] arr) =>
            {
                int min = arr[0];
                int index = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                        index = i;
                    }
                }
                Console.WriteLine($"Min - {min}; Index - {index}");
                return min;
            };
            min(new int[] { 1, 6, 2, 9, 12, 4, 8 });

            MyDelegate.Filter OnlyOdd = (int[] arr) =>
            {
                int[] outArr = new int[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        outArr.Append(arr[i]);
                    }
                }
                return outArr;
            };
            int[] Odds = OnlyOdd(new int[] { 1, 6, 2, 9, 12, 4, 8 });
            for (int i = 0; i < Odds.Length; i++)
            {
                Console.Write(Odds[i].ToString() + " ");
            }
        }
    }
    #endregion

    #region Part 2
    internal class Delegates2
    {
        public delegate void Show(string msg);
        public delegate int BinaryDel(int x, int y);
        public delegate bool Is(int x);
    }
    internal class Practice2
    {
        public static void Run()
        {
            Delegates2.Show show = (string msg) => { Console.WriteLine(msg); };
            show("Message");
            Delegates2.BinaryDel Summary = (int x, int y) => { return x + y; };
            Delegates2.BinaryDel Substruct = (int x, int y) => { return x - y; };
            Delegates2.BinaryDel Multi = (int x, int y) => { return x * y; };
            
            Delegates2.Is Even = (int x) => { return  x % 2 == 0; };
            Delegates2.Is Odd = (int x) => { return  x % 2 != 0; };
            Delegates2.Is Simple = (int x) =>
            {
                for (int i = 2; i < x / 2; i++)
                {
                    if(x % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };
        }
    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW
{
    internal class cw2
    {
        void classwork()
        {
            //1
            int[] arr = new int[] { 2, 3, 5, 9, 11, 2, 11, 20 };
            int par = 0, nepar = 0, uniq = 0, count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    nepar++;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    uniq++;
                }
                count = 0;
            }
            Console.WriteLine($"Even nums: {par}");
            Console.WriteLine($"Odd nums: {nepar}");
            Console.WriteLine($"Unique nums: {uniq}");

            //2
            int num = 5;
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < num)
                {
                    res++;
                }
            }
            Console.WriteLine($"Res nums: {res}");
        }

        void ShowInfo(int[] arr)
        {
            int par = 0, nepar = 0, uniq = 0, count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    nepar++;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    uniq++;
                    count = 0;
                }
            }
            Console.WriteLine($"Even nums: {par}");
            Console.WriteLine($"Odd nums: {nepar}");
            Console.WriteLine($"Unique nums: {uniq}");
        }
        void LessThan(int[] arr, int num)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < num)
                {
                    res++;
                }
            }
            Console.WriteLine($"Res nums: {res}");
        }


        enum PlayerStatus
        {
            Online, Offline, NoInfo
        }

    }
}

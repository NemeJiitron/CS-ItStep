using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project2.hm.HM_7;

namespace ClassWork.CW.cw7
{
    internal class MyArray : ICalc, IOutput2, ICalc2
    {
        private int[] arr { get; set; }
        public MyArray() 
        { 
            arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next() % 101;
            }
        }
        public MyArray(int[] arr) { this.arr = arr; }

        public void Show()
        {
            foreach (int item in arr)
            {
                Console.Write(item.ToString() + " " );
            }
            Console.WriteLine();
        }

        public void Show(string message)
        {
            Show();
            Console.WriteLine(message);
        }

        public int Less(int valueToCompare)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < valueToCompare)
                {
                    res += 1;
                }
            }
            return res;
        }

        public int Greater(int valueToCompare)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > valueToCompare)
                {
                    res += 1;
                }
            }
            return res;
        }

        public void ShowEven()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i].ToString() + " ");
                }
            }
            Console.WriteLine();

        }

        public void ShowOdd()
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i].ToString() + " ");
                }
            }
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            int res = 0;
            bool isCor = true;
            for (int i = 0;i < arr.Length;i++)
            {
                isCor = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && j != i)
                    {
                        isCor = false;
                    }
                }
                if (isCor)
                {
                    res++;
                }
            }
            return res;
        }

        public int EqualToValue(int valueToCompare)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare)
                {
                    res++;
                }
            }
            return res;
        }
    }
}

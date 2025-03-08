using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class MyArray : IOutput, IMath, ISort
    {
        private int[] arr { get; set; }
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

        public int Max()
        {
            return arr.Max();
        }

        public int Min()
        {
            return arr.Min();
        }

        public int Average()
        {
            return arr.Sum() / arr.Length;
        }

        public bool Search(int ValSearch)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ValSearch)
                {  return true; }
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        public void SortByParam(bool param)
        {
            if (param)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}

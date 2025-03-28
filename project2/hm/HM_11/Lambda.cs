using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_11
{
    internal class Lambda
    {
        public static void RGB(string color)
        {

            Func<string, string> getRgb = (color) =>
            {
                switch (color.ToLower())
                {
                    case "red": return "(255, 0, 0)";
                    case "orange": return  "(255, 165, 0)";
                    case "yellow": return  "(255, 255, 0)";
                    case "green": return   "(0, 128, 0)";
                    case "cyan": return    "(0, 191, 255)";
                    case "blue": return    "(0, 0, 255)";
                    case "purple": return  "(128, 0, 128)";
                    default:
                        return "";
                }
            };
            Console.WriteLine(getRgb(color));

        }

        public static void NumsAreDivisible(int[] arr, int div)
        {
            Func<int[], int, int> DivisibleNums = (arr, divisor) =>
            {
                int res = 0;
                foreach (int i in arr) if (i % divisor == 0) res++;
                return res;
            };
            Console.WriteLine(DivisibleNums(arr, div));
        }
        public static void NumsInRange(int[] arr, int x, int y)
        {
            Func<int[], int, int, int> InRange = (arr, x, y) =>
            {
                int res = 0;
                foreach (int i in arr) if (i < y && i > x) res++;
                return res;
            };
            Console.WriteLine(InRange(arr, x, y));
        }
        public static void NumsBelowZero(int[] arr)
        {
            Action<int[]> BelowZero = (arr) =>
            {
                List<int> negatives = new List<int>();
                foreach (int i in arr)
                {
                    if (i < 0) if(!negatives.Contains(i)) negatives.Add(i);
                }
                foreach (int i in negatives)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine();
            };
            BelowZero(arr);
        }

        public static void NumOfSubstrings(string text, string word)
        {
            Func<string, string, int> Substring = (text, word) =>
            {
                int res = 0;
                int index = text.IndexOf(word, 0);
                while (index != -1)
                {
                    res++;
                    index = text.IndexOf(word, index + word.Length);
                }
                return res;
            };

            Substring(text, word);
        }

    }
}

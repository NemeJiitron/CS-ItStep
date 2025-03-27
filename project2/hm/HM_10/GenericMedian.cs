using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_10
{
    internal class GenericMedian
    {
        public static T FindMedian<T>(T[] arr) where T : IComparable<T>
        {
            List<T> list = new List<T>(arr);
            list.Sort();
            foreach (T item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            if (list.Count % 2 == 0)
            {
                dynamic res = list[list.Count / 2 - 1];
                dynamic res2 = list[list.Count / 2];
                if(res is string)
                {
                    return res + " " + res2;
                }
                return (res + res2) / 2;
            }
            else
            {
                return list[list.Count / 2];
            }
        }
    }
}

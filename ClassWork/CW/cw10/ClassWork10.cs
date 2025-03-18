using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw10
{
    internal class ClassWork10
    {

    }

    public static class Extension
    {
        public static int WordNumber(this string str)
        {
            return str.Length;
        }
    }

    public record Employee(string Name, int Age, string Occupation);

    public class MyArr<T> where T : class, IComparable<T>, new()
    {
        public T[] arr;
        public MyArr(T[] arr)
        {
            this.arr = arr;
        }
        public MyArr()
        {
            this.arr = new T[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = default;
            }
        }
    }
}

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

    public record Person(string Name, int Age);
    public record Employee(string Name, int Age, string Occupation) : Person(Name, Age);

    public class MyArr<T> where T : Person
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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T t in this.arr)
            {
                sb.Append(t.ToString());
            }
            return sb.ToString();
        }
    }


}

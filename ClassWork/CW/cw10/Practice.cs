using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw10
{
    public static class ExtensionMethods
    {
        public static bool Odd(this int num)
        {
            return num % 2 != 0;
        }
        public static bool Even(this int num)
        {
            return num % 2 == 0;
        }
        public static bool Simple(this int num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int Vowels(this string str)
        {
            int res = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            foreach (char c in str)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (vowels.Contains(c))
                    {
                        res++;
                    }
                }
            }
            return res;
        }
        public static int Consonants(this string str)
        {
            int res = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            foreach (char c in str)
            {
                if (!char.IsWhiteSpace(c))
                {
                    if (!vowels.Contains(c))
                    {
                        res++;
                    }
                }
            }
            return res;
        }
        public static int Sentences(this string str)
        {
            return str[str.Length - 1] == '.' ? str.Split('.').Length - 1 : str.Split('.').Length;

        }
        // -------------------7-----------------------
        public static Person MaxAge(this Person[] persons)
        {
            int max = persons[0].age;
            int index = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].age > max)
                {
                    max = persons[i].age;
                    index = i;
                }
            }
            return persons[index];
        }
        public static Person MinAge(this Person[] persons)
        {
            int min = persons[0].age;
            int index = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].age < min)
                {
                    min = persons[i].age;
                    index = i;
                }
            }
            return persons[index];
        }
        public static int Average(this Person[] persons)
        {
            int res = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                res += persons[i].age;
            }
            return res / persons.Length;
        }
        // -------------------8-----------------------
        public static Point3D MaxDelta(this Point3D[] points)
        {
            Point3D max = points[0];
            Point3D temp;
            int index = 0;
            int index2 = 0;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    if (i != j)
                    {
                        temp = new(points[i].x - points[j].x, points[i].y - points[j].y, points[i].z - points[j].z);
                        if (temp.x > max.x)
                        {
                            max = temp;
                            index = i;
                            index2 = j;
                        }
                    }
                }
            }
            Console.WriteLine("Point 1:" + points[index].ToString());
            Console.WriteLine("Point 2:" + points[index2].ToString());
            return max;
        }
        public record Person(string FirstName, string LastName, int age);
        public record Point3D(int x, int y, int z);

        public static T GenericMax<T>(T x1, T x2, T x3) where T : IComparable
        {
            {
                return new T[] { x1, x2, x3 }.Max();
            }
        }

    }

    public class  Stack<T>
    {
        private T[] array;
        public Stack()
        {
            array = new T[0];
        }
        public void Push(T val)
        {
            array.Append(val);
        }
        public T Pop()
        {
            T[] temp = new T[array.Length - 1];
            T res = array[array.Length - 1];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = array[i];
            }
            array = temp;
            return res;
        }
        public IEnumerable Peek()
        {
            return array.AsEnumerable();
        }
        public int Count()
        {
            return array.Length;
        }           

    }
}

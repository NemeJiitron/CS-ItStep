using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw11
{
    internal class GenericMethods
    {
        //1
        public static T MaxOfThree<T>(T x, T y, T z)
        {
            T[] values = { x, y, z };
            return values.Max();
        }
        //2
        public static T MinOfThree<T>(T x, T y, T z)
        {
            T[] values = { x, y, z };
            return values.Min();
        }
        //3
        public static T GenericSum<T>(T[] arr)
        {
            dynamic res = default(T);
            foreach (T t in arr)
            {
                res += t;
            }
            return res;
        }

        //6
        public static T[] FilterByTwoCriteria<T>(T[] arr, Predicate<T> cr1, Predicate<T> cr2)
        {
            List<T> list = new List<T>();
            foreach(T t in arr)
            {
                if (cr1(t) && cr2(t))
                {
                    list.Add(t);
                }
            }
            return list.ToArray();
        }

    }

    internal class MyStack<T>
    {
        LinkedList<T> list;
        public int Count { get { return list.Count; } }
        public MyStack()
        {
            list = new LinkedList<T>();
        }

        public void Add(T val)
        {
            list.AddFirst(val);
        }
        public T Pop()
        {
            T res = list.First();
            list.RemoveFirst();
            return res;
        }
        public T Peek()
        {
            return list.First();
        }
    }

    internal class MyQueue<T>
    {
        LinkedList<T> list;
        public int Count { get { return list.Count; } }
        public MyQueue()
        {
            list = new LinkedList<T>();
        }

        public void Add(T val)
        {
            list.AddLast(val);
        }
        public T Pop()
        {
            T res = list.First();
            list.RemoveFirst();
            return res;
        }
        public T Peek()
        {
            return list.First();
        }
    }

    internal class Alphabet
    {
        char[] alphabet = {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        public Alphabet()
        {}

        public IEnumerator<char> GetEnumerator()
        {
            foreach (char c in alphabet)
            {
                yield return c;
            }
        }

    }
    

    internal class Flat : IEnumerable<string>
    {
        string[] occupants;
        public Flat(params string[] occups)
        {
            occupants = occups;
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach(string c in occupants)
            {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (string c in occupants)
            {
                yield return c;
            }
        }
    }
    internal class House : IEnumerable<Flat>
    {
        Flat[] flats;
        public House(params Flat[] flats)
        {
            this.flats = flats;
        }

        public IEnumerator<Flat> GetEnumerator()
        {
            foreach(Flat f in flats)
            {
                yield return f;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Flat f in flats)
            {
                yield return f;
            }
        }
    }
}

using System;
using System.Text;
using project2.hm;
using project2.hm.HM_4;
using static project2.hm.hm_1;
using static project2.hm.hm_2;
using static project2.hm.hm_3;
using static project2.hm.HM_4.BookList;
using static project2.hm.HM_4.TemperatureArray;
using static project2.hm.HM_4.Fraction;
using static project2.hm.HM_6.Money;
using static project2.hm.HM_5.Course;
using static project2.hm.HM_5.OnlineCourse;
using project2.hm.HM_5;
using project2.hm.HM_6;
using project2.hm.HM_8;
using ClassWork.CW.cw7;
using project2.hm.HM_9;
using project2.hm.HM_10;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hm.HM_10.PriorityQueue<int> q = new();
            //q.Enqueue(10, 1);
            //q.Enqueue(30, 3);
            //q.Enqueue(20, 2);
            //q.Enqueue(70, 7);
            //Console.WriteLine(q.ToString());
            //hm.HM_10.LinkedList<int> list = new hm.HM_10.LinkedList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.AddFirst(10);
            //list.Insert(33, 2);
            //Console.WriteLine(list.ToString());
            //list.RemoveAt(2);
            //list.RemoveAt(0);
            //Console.WriteLine(list.ToString());
            //list.Clear();
            //list.Add(100);
            //Console.WriteLine(list.ToString());
            int[] arr1 = { 5, 2, 9, 1, 6 };
            Console.WriteLine(GenericMedian.FindMedian(arr1));
            string[] arr2 = { "apple", "banana", "cherry", "date", "fig" };
            Console.WriteLine(GenericMedian.FindMedian(arr2));
            float[] arr3 = { 4, 1, 7, 9, 3, 8 };
            Console.WriteLine(GenericMedian.FindMedian(arr3));
            string[] arr4 = { "apple", "banana", "cherry", "date" };
            Console.WriteLine(GenericMedian.FindMedian(arr4));
        }

    }
}

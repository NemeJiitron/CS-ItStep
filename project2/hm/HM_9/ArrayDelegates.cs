using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project2.hm.HM_9
{
    internal class MyDelegates
    {
        public delegate int[] Filter(int[] arr);

        public static void Run()
        {
            #region 1
            Filter even = (arr) =>
            {
                int[] Out;
                int size = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        size++;
                    }
                }
                Out = new int[size];
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        Out[j] = arr[i];
                        j++;
                    }
                }
                return Out;
            };
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = even(arr);
            for (int i = 0; i < arr2.Length; i++) 
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();
            Filter odd = (arr) =>
            {
                int[] Out;
                int size = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        size++;
                    }
                }
                Out = new int[size];
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        Out[j] = arr[i];
                        j++;
                    }
                }
                return Out;
            };
            arr2 = odd(arr);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();
            Filter Simple = (arr) =>
            {
                int[] Out;
                bool isSimple = true;
                int size = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    isSimple = true;
                    if (arr[i] < 2){ continue; }
                    for (int j = 2; j * j <= arr[i]; j++)
                    {
                        if (arr[i] % j == 0)
                        {
                            isSimple = false;
                            break;
                        }
                    }
                    if(isSimple)
                    {
                        size++;
                    }

                }
                Out = new int[size];
                for (int i = 0, n = 0; i < arr.Length; i++)
                {
                    isSimple = true;
                    if (arr[i] < 2) { continue; }
                    for (int j = 2; j * j <= arr[i]; j++)
                    {
                        if (arr[i] % j == 0)
                        {
                            isSimple = false;
                            break;
                        }
                    }
                    if (isSimple)
                    {
                        Out[n] = arr[i];
                        n++;
                    }
                }
                return Out;
            };
            arr2 = Simple(arr);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();
            Filter isFibonacci = (arr) =>
            {
                int[] Out;
                int size = 0;
                int a = 0, b = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    a = 0;
                    b = 1;
                    while (b < arr[i])
                    {
                        int temp = b;
                        b = a + b;
                        a = temp;
                    }
                    if(b == arr[i])
                    {
                        size++;
                    }
                }
                Out = new int[size];
                for (int i = 0, n = 0; i < arr.Length; i++)
                {
                    a = 0;
                    b = 1;
                    while (b < arr[i])
                    {
                        int temp = b;
                        b = a + b;
                        a = temp;
                    }
                    if (b == arr[i])
                    {
                        Out[n] = arr[i];
                        n++;
                    }
                }
                return Out;
            };
            arr2 = isFibonacci(arr);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine();
            #endregion

            #region 2
            Action TimeNow = () => { Console.WriteLine(DateTime.Now.TimeOfDay.ToString()); };
            Action DateNow = () => { Console.WriteLine(DateTime.Now.Date.ToString()); };
            Action DayOfWeek = () => { Console.WriteLine(DateTime.Now.DayOfWeek.ToString()); };
            TimeNow.Invoke();
            DateNow.Invoke();
            DayOfWeek.Invoke();
            Func<int, int, int> TriangleArea = (h, b) => { return (h * b) / 2; };
            Func<int, int, int> RectangleArea = (a, b) => { return a * b; };
            Console.WriteLine(TriangleArea(5, 10));
            Console.WriteLine(RectangleArea(5, 10));
            #endregion
            
        }

    }
}

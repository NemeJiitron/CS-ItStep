using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw6
{
    internal class Practice
    {
        public static void t1()
        {
            try
            {
                string str = Console.ReadLine();
                int num = checked(int.Parse(str));
                Console.WriteLine(num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Inner Format exception");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Inner Overflow exception");
                Console.WriteLine(ex.Message);
            }
        }
        public static void t2()
        {
            try
            {
                string str = Console.ReadLine();
                int num = checked(Convert.ToInt32(str, 2));
                Console.WriteLine(num);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Inner Format exception");
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Inner Overflow exception");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

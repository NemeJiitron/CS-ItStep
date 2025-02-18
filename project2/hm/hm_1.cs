using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm
{
    internal class hm_1
    {
        internal static void FizzBuzz()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num <= 100)
            {
                string res = "";
                if (num % 3 == 0)
                {
                    res = "Fizz ";
                }
                if (num % 5 == 0)
                {
                    res += "Buzz";
                }
                if (res == "")
                {
                    Console.WriteLine(num);
                    return;
                }
                Console.WriteLine(res);
                return;
            }
            Console.WriteLine("Wrong input");
        }
        internal static void Percentage()
        {
            float num = int.Parse(Console.ReadLine());
            float perc = int.Parse(Console.ReadLine());
            num = (num / 100) * perc;
            Console.WriteLine(num);
        }
        internal static void CreateNum()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int res = (num1 * 1000) + (num2 * 100) + (num3 * 10) + num4;
            Console.WriteLine(res);
        }
        internal static void ReverseNumber()
        {
            string num = Console.ReadLine();
            if (num.Length != 6)
            {
                Console.WriteLine("Wrong input");
                return;
            }
            int arg1 = int.Parse(Console.ReadLine()) - 1;
            int arg2 = int.Parse(Console.ReadLine()) - 1;
            string res = "";
            for (int i = 0; i < num.Length; i++)
            {
                if (i == arg1)
                {
                    res += num[arg2];
                    continue;
                }
                else if (i == arg2)
                {
                    res += num[arg1];
                    continue;
                }
                res += num[i];
            }
            Console.WriteLine(res);
        }
        internal static void TemperatureConvert()
        {
            char T = Console.ReadLine()[0];
            float temp = float.Parse(Console.ReadLine());
            switch (T)
            {
                case 'F':
                    Console.WriteLine($"{temp} F = {(temp - 32) * (5f / 9f)}C");
                    break;
                case 'C':
                    Console.WriteLine($"{temp} C = {(temp * (9f / 5f)) + 32}C");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        internal static void EvenInRange()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2) {
                for (int i = num2; i <= num1; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            } else {
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        internal static void IsArmstrongNum()
        {
            string num = Console.ReadLine();
            double sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += Math.Pow(double.Parse(num[i].ToString()), num.Length);
            }
            Console.WriteLine(sum);
            if (sum == double.Parse(num))
            {
                Console.WriteLine("Is armstrong number");
                return;
            }
            Console.WriteLine("Isn`t armstrong number");
        }
        internal static void IsPerfectNum()
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= num/2; i++)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            if (sum == num)
            {
                Console.WriteLine("Is perfect number");
                return;
            }
            Console.WriteLine("Isn`t perfect number");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW
{
    internal class cw3
    {
        public static void addten(ref int value)
        {
            value += 10;
        }

        public static void printnums(params int[] nums)
        {
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
        public static void OptinParams(int val1, int val2 = 10000)
        {
            Console.WriteLine(val1);
            Console.WriteLine(val2);
        }

        public static void init(out int value)
        {
            value = 0;
        }


        public struct vector3
        {
            public int x, y, z;
            public vector3(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(x.ToString());
                sb.Append(y.ToString());
                sb.Append(z.ToString());
                return sb.ToString();
            }
        }

        //PRACTICE

        //1
        public static int Dob(int x, int y)
        {
            int res = 1;
            if (x < y)
            {
                for (int i = x; i < y; i++)
                {
                    res *= i;
                }
            }
            else
            {
                for (int i = y; i < x; i++)
                {
                    res *= i;
                }
            }
            return res;
        }
        //2
        public static bool isFibonachi(int x)
        {
            int temp;
            for (int i = 0, a = 0, b = 1; i < 1000; i++)
            {
                if (a == x)
                {
                    return true;
                }
                Console.WriteLine(a);
                temp = a + b;
                a = b;
                b = temp;
            }
            return false;
        }
    }
    
    public class player
    {
        private int health;
        private int _MaxHealth;
        private string name;
        private const int cnst = 1;
        public readonly int id;
        public int MaxHealth
        {
            get { return _MaxHealth; }
            set { _MaxHealth = value; }
        }
        public void print()
        {
            Console.WriteLine(health + " " + name);
        }
        public player() : this(100, "player", 0) { }
        public player(int health, string name, int id)
        {
            this.health = health;
            this.name = name;
            this.id = id;
        }
    }
}

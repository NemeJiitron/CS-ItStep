using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.HM_14
{
    internal class Frac
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Frac(int denominator, int numerator)
        {
            Denominator = denominator;
            Numerator = numerator;
        }
        public Frac()
        {
            Denominator = 1;
            Numerator = 1;
        }
        public static Frac Read()
        {
            int numer = int.Parse(Console.ReadLine());
            Console.WriteLine("-");
            int denom = int.Parse(Console.ReadLine());
            return new Frac(denom, numer);
        }

    }
}

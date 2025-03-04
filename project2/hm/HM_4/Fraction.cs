using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_4
{
    internal class Fraction
    {
        private int _numerator;
        private int _denominator;
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }
        private static int CommonDivisor(int den1, int den2)
        {
            int res = den1 > den2 ? den1 : den2;
            while (res % den1 != 0 || res % den2 != 0)
            {
                res++;
            }
            return res;
        }
        public void print()
        {
            Console.WriteLine(_numerator + "\n-\n" + _denominator);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int num, den;
            den = CommonDivisor(a._denominator, b._denominator);
            int mult1 = den / a._denominator;
            int mult2 = den / b._denominator;
            num = (a._numerator * mult1) + (b._numerator * mult2);
            return new Fraction(num, den);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int num, den;
            den = CommonDivisor(a._denominator, b._denominator);
            int mult1 = den / a._denominator;
            int mult2 = den / b._denominator;
            num = (a._numerator * mult1) - (b._numerator * mult2);
            return new Fraction(num, den);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int num = a._numerator * b._numerator, den = a._denominator * b._denominator;
            return new Fraction(num, den);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int num = a._numerator * b._denominator, den = a._denominator * b._numerator;
            return new Fraction(num, den);
        }
    }
}

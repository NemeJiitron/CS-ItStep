using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw6
{
    internal class CW6
    {
       public static void main()
       {
			try
			{
				int num = 5;
				Random rnd = new Random();
				int num2 = rnd.Next(0, 30);
				Console.WriteLine($"{num2}, {num}");
                if (num2 > num)
				{
					throw new SpecialException("Random num > 5");
				}
			}
			catch (SpecialException ex)
			{
				Console.WriteLine(ex.Message);
			}
       }
    }
}

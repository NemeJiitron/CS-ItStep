using System.Numerics;
using ClassWork.CW;
using static ClassWork.CW.cw3;
using static ClassWork.CW.player;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CW3
            //CW.cw3.vector3 vecc = new(1,1,1);
            //cw3.vector3 vec = new(1, 2, 3);
            //cw3.vector3 vec2 = new(1, 2, 3);
            //Console.WriteLine(vector3.Equals(vec, vec2));
            //Console.WriteLine(vec.GetType());
            //Console.WriteLine(vec.ToString());
            //Console.WriteLine(vec.y);
            //vec.y = 3;
            //Console.WriteLine(vec.y);
            //player player = new();
            //player.print();
            //player.MaxHealth = 1000;
            //Console.WriteLine(player.MaxHealth);
            //Console.WriteLine();

            //int val = 0;
            //cw3.init(out val);
            //Console.WriteLine(val);

            //cw3.addten(ref val);
            //Console.WriteLine(val);

            //Console.WriteLine();
            //cw3.printnums(3, 1, 2, 3, 4, 1, 32);

            //Console.WriteLine();
            //cw3.OptinParams(3, 10);
            //Console.WriteLine(cw3.Dob(10, 20));
            //Console.WriteLine(cw3.isFibonachi(144));
            #endregion
            #region CW4
            CW.Point p1 = new(1, 2);
            CW.Point p2 = new(6, 4);
            CW.Point p3 = p1 + p2;
            Console.WriteLine(p3[0] + " ; " + p3[1]);
            p3[0] = 0;
            p3[1] = 0;
            Console.WriteLine(p3[0] + " ; " + p3[1]);
            #endregion
        }
    }
}

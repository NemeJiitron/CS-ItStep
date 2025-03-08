using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class Auto : IMovement
    {
        public Auto() { }
        void IMovement.Move()
        {
            Console.WriteLine("vroom vroom");
        }
        void IMovement.Stop()
        {
            Console.WriteLine("stop vroomvroom");
        }
    }
}

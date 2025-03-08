using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class Circle : IShape
    {
        public int Radius { get; set; }

        public float CalculateArea()
        {
            return 3.14f * Radius * Radius;
        }

        public float CalculatePerimeter()
        {
            return 2 * 3.14f * Radius;
        }
    }
}

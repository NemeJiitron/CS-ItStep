using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class Square : IShape
    {
        public int Width { get; set; }

        public float CalculateArea()
        {
            return Width * Width;
        }

        public float CalculatePerimeter()
        {
            return Width * 4;
        }
    }
}

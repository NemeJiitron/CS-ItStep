using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.HM_16
{
    internal interface IShape
    {
        void Draw();
    }
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }
    internal class Rect : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
    internal abstract class ShapeFactory
    {
        public abstract IShape Create();
    }
    internal class CircleFactory : ShapeFactory
    {
        public override IShape Create()
        {
            return new Circle();
        }
    }
    internal class RectFactory : ShapeFactory
    {
        public override IShape Create()
        {
            return new Rect();
        }
    }

}

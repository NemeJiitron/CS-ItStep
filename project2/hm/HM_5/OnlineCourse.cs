using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class OnlineCourse : Course
    {
        public readonly string Platform;
        public OnlineCourse(string name, string duration, string platform) : base(name, duration)
        {
            Platform = platform;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nPlatform: {Platform}";
        }
    }
}

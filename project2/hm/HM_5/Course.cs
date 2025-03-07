using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_5
{
    internal class Course
    {
        public readonly string Name;
        public readonly string Duration;
        public Course(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nDuration: {Duration}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_9
{
    internal class Alarm
    {
        private string _code = "1234";
        public void OnDoorOpen()
        {
            Console.WriteLine("Security code: ");
            string code = Console.ReadLine();
            if (code == _code)
            {
                Console.WriteLine("Your welcome!");
            }
            else
            {
                Console.WriteLine("Wrong code");
            }
        }
    }
}

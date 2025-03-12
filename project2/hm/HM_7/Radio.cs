using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_7
{
    internal class Radio : IRemoteControl
    {
        private int cur_channel;
        private bool is_On;
        public Radio()
        {
            is_On = false;
            cur_channel = 0;
        }

        public void SetChannel(int channel)
        {
            if (is_On)
            {
                Console.WriteLine("Channel switched to " + channel.ToString());
                cur_channel = channel;
                return;
            }
            Console.WriteLine("Radio is off");
        }

        public void TurnOff()
        {
            is_On = false;
            Console.WriteLine("Radio is off");
        }

        public void TurnOn()
        {
            is_On = true;
            Console.WriteLine("Radio is on");
        }
    }
}

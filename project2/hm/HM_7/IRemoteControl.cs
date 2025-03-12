using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_7
{
    internal interface IRemoteControl
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_9
{
    internal class Door
    {
        public delegate void DoorDelegate();
        public event DoorDelegate OnOpenDoor;
        public bool isOpened { get; set; }
        public void OpenDoor()
        {
            OnOpenDoor.Invoke();
        }
    }
}

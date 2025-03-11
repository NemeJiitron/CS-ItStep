using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_6
{
    [Serializable]
    public class BankrutException : ApplicationException
    {
        public DateTime Time = DateTime.Now;
        public BankrutException() { }
        public BankrutException(string message) : base(message) { }
        public BankrutException(string message, Exception inner) : base(message, inner) { }
        protected BankrutException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

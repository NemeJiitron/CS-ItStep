using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw6
{

	[Serializable]
	public class SpecialException : ApplicationException
	{
		public DateTime Time = DateTime.Now;
		public SpecialException() { }
		public SpecialException(string message) : base(message) { }
		public SpecialException(string message, Exception inner) : base(message, inner) { }
		protected SpecialException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}

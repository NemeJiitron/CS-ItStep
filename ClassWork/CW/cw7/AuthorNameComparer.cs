using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal class AuthorNameComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Book left && y is Book right)
            {
                return string.Compare(left.author.FirstName, right.author.FirstName);
            }
            throw new NotSupportedException("using of unsupported type");
        }
    }
}

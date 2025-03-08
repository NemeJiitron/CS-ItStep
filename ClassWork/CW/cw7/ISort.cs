using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.CW.cw7
{
    internal interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool param);
    }
}

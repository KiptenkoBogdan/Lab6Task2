using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task2
{
    public class SortByWindowCount:IComparer<MyRoom>
    {
        public int Compare(MyRoom r1, MyRoom r2)
        {
            return r1.GetArea.CompareTo(r2.GetArea);
        }
    }
}

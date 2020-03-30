using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task2
{
    class ClassRoom: MyRoom
    {
        int desk_count;

        public ClassRoom(double a, int w_c, int d_c):base(a, w_c)
        {
            this.desk_count = d_c;
        }
        public void GetInfo()
        {
            Console.WriteLine("\tRoom info");
            Console.WriteLine("Area: {0}", this.area);
            Console.WriteLine("Window count: {0}", this.window_count);
            Console.WriteLine("Desk count: {0}", this.desk_count);
        }
    }
}

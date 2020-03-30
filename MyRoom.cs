using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task2
{
    public class MyRoom: IComparable<MyRoom>
    {
        protected double area;
        protected int window_count;
        public MyRoom(double a, int w_c)
        {
            this.area = a;
            this.window_count = w_c;
        }
        public double GetArea
        {
            get
            {
                return this.area;
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("\tRoom info");
            Console.WriteLine("Area: {0}", this.area);
            Console.WriteLine("Window count: {0}", this.window_count);
        }
        public int CompareTo(MyRoom r2)
        {
            return this.area.CompareTo(r2.area);
        }
        public void Sorting(MyRoom[] arr)
        {
            Array.Sort(arr, new SortByWindowCount());
        }
        public void GetAllInfo(MyRoom[] R, int n)
        {
            for (int i = 0; i < n; i++)
                R[i].GetInfo();
        }
    }
}

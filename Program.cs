using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRoom mr1 = new MyRoom(36, 1);
            ClassRoom cr1 = new ClassRoom(50, 3, 15);
            MyRoom[] rooms = new MyRoom[] { mr1, cr1 };

            mr1.GetInfo();
            cr1.GetInfo();

            if (mr1.CompareTo(cr1) == 1)
            {
                Console.WriteLine("\nMy room is bigger than the classroom");
            }
            else if (mr1.CompareTo(cr1) == 0)
            {
                Console.WriteLine("\nMy room is as big as the classroom");
            }
            else
            {
                Console.WriteLine("\nMy room is smaller than the classroom");
            }

            Console.WriteLine("\nSorting rooms by window count");
            rooms[0].Sorting(rooms);
            rooms[0].GetAllInfo(rooms, 2);

            Console.ReadKey();
        }
    }
}

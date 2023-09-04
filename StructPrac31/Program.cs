using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPrac31
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;
        }


        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 10;
            Console.WriteLine($"{p.x} - {p.y}");
        }
    }
}

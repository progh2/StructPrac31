using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            public string testA;
            public string testB;

            public Point (int number)
            {
                x = number;
                y = number;
                testA = testB = null;
            }

            public Point(int a, int b)
            {
                x = a; y = b;
                testA = "에이";
                testB = "비이";
            }
        }


        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 10;
            Console.WriteLine($"{p.x} - {p.y}");

            Point p2 = new Point();
            Console.WriteLine($"{p2.x} - {p2.y}");
        }
    }
}

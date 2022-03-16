using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(10));
            Console.WriteLine(CalculateArea(20,10));
            Console.WriteLine(CalculateArea(5,10,20));
        }
        static int CalculateArea(int r)
        {
            const int p= 3;
            int CircleArea = p * r * r;
            return CircleArea;
        }

        static int CalculateArea(int a, int b)
        {
            int RectangularArea = a * b;
            return RectangularArea;
        }

        static int CalculateArea(int a, int b, int c)
        {
            int ParallelepipedArea = 2*(a * b + a * c + b * c);
            return ParallelepipedArea;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_3_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        static void Value()
        {
            int x1 = Input("x1=");
            int y1 = Input("y1=");
            int x2 = Input("x2=");
            int y2 = Input("y2=");
            int x3 = Input("x3=");
            int y3 = Input("y3=");
            double a = F(x1, y1, x2, y2);
            double b = F(x2, y2, x3, y3);
            double c = F(x3, y3, x1, y1);
            if (a == b && b == c)
            {
                Console.Write("Треугольник равносторонний");
            }
            else if (a == b || b == c || c == a)
            {
                Console.Write("Треугольник равнобедренный");
            }
            else
            {
                Console.WriteLine("Треугольник обычный.");
            }
            Console.ReadLine();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static double F(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static double Func(double a, double b)
        {
            return a > b ? a : b;
        }
    }
}

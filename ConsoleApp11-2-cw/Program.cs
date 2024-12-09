using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_2_cw
{
    /// <summary>
    /// Составить программу, в результате которой величина а меняется значением с величиной b, а величина c — с величиной d.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        public static void Value()
        {
            int a = Input("Введите 1 число:");
            int b = Input("Введите 2 число:");
            int c = Input("Введите 3 число:");
            int d = Input("Введите 4 число:");
            Conclusion("До изменений", a, b, c, d);
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Conclusion("После изменений", a, b, c, d);
            Console.ReadKey();
        }
        public static void Swap(ref int a, ref int b)
        {
            int p = a;
            a = b;
            b = p;
        }
        public static int Input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        public static void Conclusion(string message, int a, int b, int c, int d)
        {
            Console.WriteLine($"{message} {a} {b} {c} {d}");
        }
    }
}
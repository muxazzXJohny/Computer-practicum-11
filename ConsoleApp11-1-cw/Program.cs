using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_1_cw
{
    /// <summary>
    /// Поменять местами содержимое двух строковых переменных.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
        }
        public static void Value()
        {
            string st1 = "Это первая строка";
            string st2 = "Это вторая строка";
            Console.WriteLine($"Вывод перед обменом:{st1}\t{st2}");
            Swap(ref st1, ref st2);
            Console.WriteLine($"Вывод после обмена:{st1}\t{st2}");
            Console.ReadKey();
        }

        public static void Swap(ref string x, ref string y)
        {
            string p = x;
            x = y;
            y = p;
        }
    }
}

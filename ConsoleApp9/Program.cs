using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public static double Funk1(int a) //int b
        {
            return (Math.Sqrt(a) + a); // (Math.Sqrt(b) + b)
        }
        public static double Funk2(int b)
        {
            return (Math.Sqrt(b) + b);
        }
        static void Main(string[] args)
        {
            //Задача 2. Вычислить значение выражения,
            //определив и использовав дополнительный метод.
            double x = Funk1(5) / Funk2(7) + Funk1(12) / Funk2(8) + Funk1(19) / Funk2(2);
            Console.WriteLine($"x={x}");
            Console.Read();
        }
    }
}

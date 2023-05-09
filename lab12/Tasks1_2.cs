using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class Tasks1_2
    {
        public static void Run1()
        {
            Console.WriteLine($"Max of (3,5,-10) sequence: {Max<int>(3, 5, -10)}");
            Console.WriteLine($"Max of (-23.1, 6.7, 9.12) sequence: {Max<double>(-23.1, 6.7, 9.12)}");
        }

        public static void Run2()
        {
            Console.WriteLine($"Min of (3,5,-10) sequence: {Min<int>(3, 5, -10)}");
            Console.WriteLine($"Min of (-23.1, 6.7, 9.12) sequence: {Min<double>(-23.1, 6.7, 9.12)}");

        }

        private static T Min<T>(T first, T second, T third)
        {
            dynamic a = (dynamic)first, b = (dynamic)second, c = (dynamic)third;
            if (a <= b && a <= c)
                return a;
            if (b <= a && b <= c)
                return b;
            return c;
        }

        private static T Max<T>(T first, T second, T third)
        {
            dynamic a = (dynamic)first, b = (dynamic)second, c = (dynamic)third;
            if (a >= b && a >= c)
                return a;
            if (b >= a && b >= c)
                return b;
            return c;
        }
    }
}

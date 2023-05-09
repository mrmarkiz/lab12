using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class Task3
    {
        public static void Run()
        {
            int[] arrInt = new int[] { 1, 4, 10, -5, -1 };
            double[] arrDouble = new double[] { -3.4, 9.2, 4.8, -2.5 };
            Console.Write("Array: ");
            Show<int>(arrInt);
            Console.WriteLine($"Sum: {Sum<int>(arrInt)}");
            Console.Write("Array: ");
            Show<double>(arrDouble);
            Console.WriteLine($"Sum: {Sum<double>(arrDouble)}");
        }

        public static void Show<T>(T[] array)
        {
            foreach(T item in array)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        private static T Sum<T>(T[] array)
        {
            dynamic sum = (dynamic)0;
            foreach(T item in array)
            {
                sum += item;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class Task4
    {
        public static void Run()
        {
            Steck<int> steck = new Steck<int>(new int[] { 1, 3, -3, 7, 12, 30 });
            Console.WriteLine("Steck elements:");
            steck.Show();
            Console.WriteLine();
            Console.WriteLine($"Result of Pop func: {steck.Pop()}");
            Console.WriteLine("Steck elements after Pop func:");
            steck.Show();
            Console.WriteLine();
            steck.Push(54);
            Console.WriteLine("Steck elements after Push func(for number 54):");
            steck.Show();
            Console.WriteLine();
            Console.WriteLine($"Result of Peek func: {steck.Peek()}");
            Console.WriteLine("Steck elements after Peek func:");
            steck.Show();
            Console.WriteLine();
            Console.WriteLine($"Result of Count func: {steck.Count()}");
            Console.WriteLine("Steck elements after Count func:");
            steck.Show();
            Console.WriteLine();
        }
    }
    public class Steck<T>
    {
        private T[] array { get; set; }
        public Steck() 
        {
            array = new T[0];
        }
        public Steck(T[] values)
        {
            array = new T[values.Length];
            for (int i = 0; i < values.Length; i++)
                array[i] = values[i];
        }

        public void Show()
        {
            foreach (T item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public T Pop()
        {
            T val = array[array.Length - 1];
            T[] newArray = new T[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = array[i];
            array = newArray;
            return val;
        }

        public void Push(T val)
        {
            array = array.Append(val).ToArray();
        }

        public T Peek()
        {
            return array[array.Length - 1];
        }

       public int Count()
        {
            return array.Length;
        }
    }
}

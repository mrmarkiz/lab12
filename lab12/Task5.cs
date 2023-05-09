using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class Task5
    {
        public static void Run()
        {
            Queue<int> queue = new Queue<int>(new int[] { 1, 3, -3, 7, 12, 30 });
            Console.WriteLine("Queue elements:");
            queue.Show();
            Console.WriteLine();
            Console.WriteLine($"Result of Dequeue func: {queue.Dequeue()}");
            Console.WriteLine("Queue elements after Dequeue func:");
            queue.Show();
            Console.WriteLine();
            queue.Enqueue(54);
            Console.WriteLine("Queue elements after Enqueue func(for number 54):");
            queue.Show();
            Console.WriteLine();
            Console.WriteLine($"Result of Enqueue func: {queue.Peek()}");
            Console.WriteLine("Queue elements after Peek func:");
            queue.Show();
            Console.WriteLine();
            Console.WriteLine($"Result of Count func: {queue.Count()}");
            Console.WriteLine("Queue elements after Count func:");
            queue.Show();
            Console.WriteLine();
        }
    }
    public class Queue<T>
    {
        private T[] array { get; set; }
        public Queue()
        {
            array = new T[0];
        }
        public Queue(T[] values)
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

        public T Dequeue()
        {
            T val = array[0];
            T[] newArray = new T[array.Length - 1];
            for (int i = 1; i < newArray.Length + 1; i++)
                newArray[i - 1] = array[i];
            array = newArray;
            return val;
        }

        public void Enqueue(T val)
        {
            array = array.Append(val).ToArray();
        }

        public T Peek()
        {
            return array[0];
        }

        public int Count()
        {
            return array.Length;
        }
    }
}

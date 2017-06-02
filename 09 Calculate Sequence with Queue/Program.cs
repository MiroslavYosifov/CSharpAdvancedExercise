using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Calculate_Sequence_with_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            var queue2 = new Queue<long>();

            queue.Enqueue(n);
            queue2.Enqueue(n);
                   
            for (int i = 0; i < 17; i++)
            {
                CalculateNumbers(queue, queue2);
            }

            var rolls = queue.Count - 2;

            for (int i = 0; i < rolls; i++)
            {
                Console.Write(queue.Dequeue());
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void CalculateNumbers(Queue<long> queue, Queue<long> queue2)
        {
            long s1 = queue2.Dequeue();
            long s2 = s1 + 1;
            long s3 = (s1 * 2) + 1;
            long s4 = s1 + 2;

            queue.Enqueue(s2);
            queue.Enqueue(s3);
            queue.Enqueue(s4);

            queue2.Enqueue(s2);
            queue2.Enqueue(s3);
            queue2.Enqueue(s4);
        }

    }
}

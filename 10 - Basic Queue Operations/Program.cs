using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var stack = new Stack<int>();

            for (int i = 0; i < input[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }

            if (!stack.Contains(input[2]) && stack.Count > 0)
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

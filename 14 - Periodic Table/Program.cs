using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var uniqueElements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split();
               
                for (int j = 0; j < elements.Length; j++)
                {
                    uniqueElements.Add(elements[j]);
                }
            }

           var sortedElements = uniqueElements.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(" ", sortedElements));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthOfSet = Console.ReadLine().Split();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            var sumOfBothSets = int.Parse(lengthOfSet[0]) + int.Parse(lengthOfSet[1]);

            for (int i = 1; i <= sumOfBothSets; i++)
            {
                var nums = int.Parse(Console.ReadLine());
                if(i <= int.Parse(lengthOfSet[0]))
                {
                    firstSet.Add(nums);
                }
                else
                {
                    secondSet.Add(nums);
                }
            }

            foreach (var item in firstSet)
            {
                if(secondSet.Contains(item))
                {
                    Console.Write("{0} ",item);
                }
            }
            Console.WriteLine();
        }
    }
}

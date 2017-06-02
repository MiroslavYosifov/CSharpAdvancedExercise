using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01__Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var collectionNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name =  Console.ReadLine();
                collectionNames.Add(name);
            }

            foreach (var item in collectionNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}

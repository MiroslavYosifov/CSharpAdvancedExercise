using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dataSymbols = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if(!dataSymbols.ContainsKey(item))
                {
                    dataSymbols[item] = 1;
                }
                else
                {
                    dataSymbols[item]++;
                }
            }

            foreach (var symbol in dataSymbols.OrderBy(x=>x.Key).ToDictionary(x=>x.Key,x=>x.Value))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
            
        }
    }
}

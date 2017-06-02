using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var dataNumbers = new Dictionary<string, string>();


            while(inputLine != "search")
            {
                var parts = inputLine.Split('-');
                var name = parts[0];
                var number = parts[1];

                if(!dataNumbers.ContainsKey(name))
                {
                    dataNumbers[name] = number;
                }
                else
                {
                    dataNumbers[name] = number;
                }
                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "stop")
            {
                if(dataNumbers.ContainsKey(inputLine))
                {
                    Console.WriteLine("{0} -> {1}",inputLine,dataNumbers[inputLine]);
                }
                else
                {
                    Console.WriteLine($"Contact {inputLine} does not exist.");
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}

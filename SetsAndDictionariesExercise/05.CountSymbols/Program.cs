using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbols = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            foreach (var symbol in input)
            {
                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 1);
                }
                else
                {
                    symbols[symbol]++;
                }
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}

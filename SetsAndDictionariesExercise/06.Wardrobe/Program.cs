using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe.Add(input[0], new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if(!wardrobe[input[0]].ContainsKey(clothes[j]))
                    {
                        wardrobe[input[0]].Add(clothes[j], 1);
                    }
                    else
                    {
                        wardrobe[input[0]][clothes[j]]++;
                    }
                }
            }
            string[] clothesNeeded = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);


            foreach (var colors in wardrobe)
            {
                Console.WriteLine($"{colors.Key} clothes:");
                foreach (var clothes in colors.Value)
                {
                    if(clothesNeeded[0]==colors.Key && clothesNeeded[1]==clothes.Key)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }
        }
    }
}

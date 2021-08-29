using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            var vloggers = new Dictionary<string, Stats>();
            string input = Console.ReadLine();
            while (input?.ToUpper() != "STATISTICS")
            {
                string[] splitter = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (splitter[1].ToUpper() == "JOINED")
                {
                    if (!vloggers.ContainsKey(splitter[0]))
                    {
                        vloggers.Add(splitter[0], new Stats());
                    }
                }
                else if (splitter[1]?.ToUpper() == "FOLLOWED")
                {
                    if (splitter[0] != splitter[2] && vloggers.ContainsKey(splitter[2]) && vloggers.ContainsKey(splitter[0]))
                    {
                        vloggers[splitter[2]].Followers.Add(splitter[0]);
                        vloggers[splitter[0]].Following.Add(splitter[2]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int i = 1;
            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                Console.WriteLine($"{i++}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");
                if (i == 2)
                {
                    foreach (var item in vloggers[vlogger.Key].Followers)
                    {
                        Console.WriteLine($"*  {item}");

                    }
                }
            }
        }
    }
    class Stats
    {
        public SortedSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
        public Stats()
        {
            Followers = new SortedSet<string>();
            Following = new HashSet<string>();
        }

    }
}

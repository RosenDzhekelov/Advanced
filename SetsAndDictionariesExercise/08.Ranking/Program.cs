using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while(input?.ToUpper()!="END OF CONTESTS")
            {
                string[] splitter = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                contests.Add(splitter[0], splitter[1]);
                input = Console.ReadLine();
            }
            string submission = Console.ReadLine();
            var interns = new SortedDictionary<string, Dictionary<string, int>>();
            while(submission.ToUpper()!="END OF SUBMISSIONS")
            {
                string[] splitter = submission
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                //"{contest}=>{password}=>{username}=>{points}" 
                string contest = splitter[0];
                string password = splitter[1];
                if(contests.ContainsKey(contest)&&contests[contest]==password)
                {
                    string username = splitter[2];
                    int points = int.Parse(splitter[3]);
                    if(!interns.ContainsKey(username))
                    {
                        interns.Add(username, new Dictionary<string, int>());
                    }
                    if(!interns[username].ContainsKey(contest))
                    {
                        interns[username].Add(contest, points);
                    }
                    else if (interns[username][contest] < points)
                    {
                            interns[username][contest] = points;
                    }
                }
                submission = Console.ReadLine();
            }
            string bestName = " ";
            int bestPoints = 0;
            int currentPoints = 0;
            foreach (var intern in interns)
            {
                foreach (var item in intern.Value)
                {
                        currentPoints += item.Value;
                    if(currentPoints>bestPoints)
                    {
                        bestPoints = currentPoints;
                        bestName = intern.Key;
                    }
                }
                currentPoints = 0;
            }
            Console.WriteLine($"Best candidate is {bestName} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var intern in interns)
            {
                Console.WriteLine(intern.Key);
                foreach (var item in intern.Value.OrderByDescending(x=> x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}

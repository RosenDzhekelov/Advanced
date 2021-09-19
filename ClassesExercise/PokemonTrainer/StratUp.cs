using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    class StratUP
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (true)
            {
                string[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (lines[0] == "Tournament")
                {
                    string command = Console.ReadLine();
                    while (command != "End")
                    {
                        CheckElement(command, trainers);
                        command = Console.ReadLine();
                    }
                    break;
                }
                else
                {
                    Pokemon pokemon = new Pokemon(lines[1], lines[2], int.Parse(lines[3]));
                    if (!trainers.ContainsKey(lines[0]))
                    {
                        Trainer trainer = new Trainer();
                        trainer.Name = lines[0];
                        trainer.Pokemons.Add(pokemon);
                        trainers.Add(lines[0], trainer);
                    }
                    else
                    {
                        trainers[lines[0]].Pokemons.Add(pokemon);
                    }
                }
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
        static void CheckElement(string element, Dictionary<string, Trainer> trainers)
        {
            foreach (var trainer in trainers)
            {
                if(trainer.Value.Pokemons.Any(x=> x.Element== element))
                {
                    trainer.Value.Badges++;
                }
               else
                {
                    trainer.Value.Pokemons.ForEach(x => x.Health -= 10);
                    trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }
        }
    }
}

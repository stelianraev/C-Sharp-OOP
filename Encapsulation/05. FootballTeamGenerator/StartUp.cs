using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        public static void Main()
        {
            List<Team> teams = new List<Team>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var inputArgs = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
                var command = inputArgs[0];

                try
                {
                    if (command == "Team")
                    {
                        teams.Add(new Team(inputArgs[1]));

                    }
                    else if (command == "Add")
                    {
                        if (!teams.Any(t => t.Name == inputArgs[1]))
                        {
                            throw new ArgumentException($"Team {inputArgs[1]} does not exist.");
                        }
                        else
                        {
                            var currentTeam = teams.First(t => t.Name == inputArgs[1]);
                            currentTeam.Add(new Player(inputArgs[2], int.Parse(inputArgs[3]), int.Parse(inputArgs[4]), int.Parse(inputArgs[5]), int.Parse(inputArgs[6]), int.Parse(inputArgs[7])));

                        }
                    }
                    else if(command == "Remove")
                    {
                        var teamToRemove = teams.First(t => t.Name == inputArgs[1]);
                        teamToRemove.RemovePlayer(inputArgs[2]);
                    }
                    else if (command == "Rating")
                    {
                        if(!teams.Any(t => t.Name == inputArgs[1]))
                        {
                            throw new ArgumentException($"Team {inputArgs[1]} does not exist.");
                        }
                        else
                        {
                            Console.WriteLine(teams.First(t => t.Name == inputArgs[1]).ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

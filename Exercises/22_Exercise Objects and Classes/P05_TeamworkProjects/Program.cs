using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_TeamworkProjects
{
    class Team
    {
        public Team(string str1, string str2)
        {
            this.Creator = str1;
            this.TeamName = str2;
            this.Members = new List<string>();
        }
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string user = input[0];
                string teamName = input[1];

                bool IsCteared = teams.Any(t => t.TeamName == teamName);

                if (IsCteared)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                
                bool IsSameUser = teams.Any(x => x.Creator == user);
                if(IsSameUser)
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
                else if(!IsCteared)
                {
                    Team team = new Team(user, teamName);
                    teams.Add(team);

                    Console.WriteLine($"Team {teamName} has been created by {user}!");
                }                
            }

            string inputs = Console.ReadLine();

            while (inputs != "end of assignment")
            {
                string[] inputArgm = inputs
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string member = inputArgm[0];
                string newTeamName = inputArgm[1];

                Team searchTeam = teams.FirstOrDefault(t => t.TeamName == newTeamName);
                
                if (searchTeam == null)
                {
                    Console.WriteLine($"Team {newTeamName} does not exist!");
                }                

                bool IsMemberExist = teams.Any(x => x.Members.Contains(member) || x.Creator == member);
                if(IsMemberExist)
                {
                    Console.WriteLine($"Member {member} cannot join team {newTeamName}!");
                }
                else if (searchTeam != null)
                {
                    searchTeam.Members.Add(member);
                }

                inputs = Console.ReadLine();
            }

            List<Team> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(z => z.Members.Count)
                .ThenBy(y => y.TeamName)
                .ToList();

            foreach(var team in teamsWithMembers)
            {
                string teamName = team.TeamName;
                string creator = team.Creator;

                Console.WriteLine($"{teamName}");
                Console.WriteLine($"- {creator}");

                foreach(var member in team.Members.OrderBy(x => x))
                {                   
                    Console.WriteLine($"-- {member}");
                }
            }

            List<Team> disbandTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            Console.WriteLine("Teams to disband:");

            if(disbandTeams.Count > 0)
            {
                foreach (var team in disbandTeams)
                {
                    Console.WriteLine(team.TeamName);
                }
            }
        }
    }
}

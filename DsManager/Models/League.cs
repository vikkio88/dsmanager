using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public class League
    {
 

        public List<Team> leagueTeams;
        public Dictionary<Team, int> table;
        public MyDictionary scorers;
        int roundsnumber = 0;
        int currentround = 0;

        public League(List<Team> Teamlist)
        {
            if ((Teamlist.Count % 2) != 0)
            {
                throw new Exception("Must be a pair number of teams");
            }

            leagueTeams = Teamlist;
            table = new Dictionary<Team, int>();
            foreach (Team t in Teamlist)
            {
                table.Add(t, 0);
            }

            roundsnumber = leagueTeams.Count - 1;

        }

        public void generateFixture()
        {

        }

        public void simulateRound()
        {
            List<Match> results = new List<Match>();

            foreach (Match m in results)
            {
                m.Score();
            }

            refreshTable(results);
           // refreshScorers(results);
        }

        public string getTableString()
        {
            string res = "";

            int c = 1;
            foreach (KeyValuePair<Team, int> pair in table)
            {
                res += c.ToString()+". "+pair.Key.TeamName + " --- " + pair.Value+"\n";
                c++;
            }


            return res;
        }

        private void refreshScorers(List<Match> results)
        {
            foreach (Match m in results)
            {
                foreach (Player pl in m.Result.scorerHome)
                {
                    addToScorer(pl,m.HomeTeam);
                }
                foreach (Player pl in m.Result.scorerAway)
                {
                    addToScorer(pl, m.AwayTeam);
                }
            }
        }

        private void addToScorer(Player pl, Team team)
        {
            //Attenzione possono esistere giocatori con lo stesso nome in
            //squadre diverse

            if (!scorers.ContainsKey(pl))
            {
                scorers.Add(pl, team.TeamName, 1);
            }
            else
            {
                TeamGoals temp = scorers[pl];
                temp.goals += 1;
                scorers[pl] = temp;
            }
        }

        private void refreshTable(List<Match> results)
        {
            foreach (Match m in results)
            {
                if (!m.Draw())
                {
                    table[m.Winner()] += 3;
                }
                else
                {
                    table[m.HomeTeam] += 1;
                    table[m.AwayTeam] += 1;
                }
            }
        }

        public void ListMatches(List<Team> ListTeam1)
        {
            List<string> ListTeam = new List<string>();
            foreach (Team item in ListTeam1)
            {
                ListTeam.Add(item.TeamName);
            }

            int numTeams = ListTeam.Count;

            int numDays = (numTeams - 1);
            int halfSize = numTeams / 2;

            List<string> teams = new List<string>();

            teams.AddRange(ListTeam.Skip(halfSize).Take(halfSize));
            teams.AddRange(ListTeam.Skip(1).Take(halfSize - 1).ToArray().Reverse());

            int teamsSize = teams.Count;

            for (int day = 0; day < numDays; day++)
            {
                Console.WriteLine("Day {0}", (day + 1));

                int teamIdx = day % teamsSize;

                Console.WriteLine("{0} vs {1}", teams[teamIdx], ListTeam[0]);

                for (int idx = 1; idx < halfSize; idx++)
                {
                    int firstTeam = (day + idx) % teamsSize;
                    int secondTeam = (day + teamsSize - idx) % teamsSize;
                    Console.WriteLine("{0} vs {1}", teams[firstTeam], teams[secondTeam]);
                }
            }
        }



    }
    public struct TeamGoals
    {
        public string TeamName;
        public int goals;
    }

    public class MyDictionary : Dictionary<Player, TeamGoals>
    {
        public void Add(Player pl, string tname, int goals)
        {
            TeamGoals tg;
            tg.TeamName = tname;
            tg.goals = goals;
            this.Add(pl, tg);

        }
    }
}

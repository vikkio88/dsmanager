using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public class MatchResult
    {
        private int goalHome;
        private int goalAway;
        List<Player> scorerHome;
        List<Player> scorerAway;

        public MatchResult(int p1, int p2)
        {
            this.goalHome = p1;
            this.goalAway = p2;
            scorerHome = new List<Player>();
            scorerAway = new List<Player>();
        }
        public override string ToString()
        {
            string res = string.Format("{0} - {1}",this.goalHome.ToString(),this.goalAway.ToString());
            if (goalAway != 0 || goalHome != 0)
            {
                res += "\n*********\nMarcatori\n";
                if (goalHome != 0)
                {
                    res += "*********\nSquadra Casa\n";
                    foreach (Player player in scorerHome)
                    {
                        res += player.ToString() + "\n";
                    }
                }
                if (goalAway != 0)
                {
                    res += "*********\nSquadra Trasferta\n";
                    foreach (Player player in scorerAway)
                    {
                        res += player.ToString() + "\n";
                    }
                }
            }
            return res;
        }

        public void Goals(Team homeTeam, Team awayTeam)
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            for (int i = 0; i < goalHome; i++)
            {    
                scorerHome.Add(homeTeam.getPlayer(rnd.getInt(11)));
            }

            for (int i = 0; i < goalAway; i++)
            {
                scorerAway.Add(awayTeam.getPlayer(rnd.getInt(11)));
            }
        }
    }
}

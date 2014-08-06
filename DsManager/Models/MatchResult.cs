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
        List<Player> scorer;

        public MatchResult(int p1, int p2)
        {
            this.goalHome = p1;
            this.goalAway = p2;
            scorer = new List<Player>();
        }
        public override string ToString()
        {
            string res = string.Format("{0} - {1}",this.goalHome.ToString(),this.goalAway.ToString());
            res += "\nMarcatori\n";
            
            foreach (Player player in scorer)
            {
                res += player.ToString()+"\n";
            }
            return res;
        }

        public void Goals(Team homeTeam, Team awayTeam)
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            for (int i = 0; i < goalHome; i++)
            {    
                scorer.Add(homeTeam.getPlayer(rnd.getInt(11)));
            }

            for (int i = 0; i < goalAway; i++)
            {
                scorer.Add(awayTeam.getPlayer(rnd.getInt(11)));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public class Team
    {
        private string teamName;
        private List<Player> players;
        private Coach coach;



        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public Team(string t)
        {
            teamName = t;
            players = new List<Player>();
            coach = new Coach();
        }


        public void setCoach(Coach c){
            coach = c;
        }

        public void addPlayer(Player p)
        {
            players.Add(p);
        }

        public int getAvgTeam()
        {
            int tot = 0;
            foreach (Player player in players)
            {
                tot += player.SkillAvg;
            }

            return tot / players.Count;
        }

        public double getAvgVal()
        {
            double tot = 0;
            foreach (Player player in players)
            {
                tot += player.Val;
            }

            return tot / players.Count;
        }

        public override string ToString()
        {
            string result = TeamName+" \n";
            foreach (Player player in players)
            {
                result += player.ToString() +"\n";
            }
            result += "media: " + getAvgTeam().ToString()+"\n";
            result += "media valore: " + getAvgVal().ToString() + "M €";
            return result;

        }




        internal Player getPlayer(int i)
        {
            return players.ElementAt(i);
        }
    }
}

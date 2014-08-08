using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public class Team: IComparable
    {
        private string teamName;
        private List<Player> players;
        private Coach coach = null;
        private int avg;
        private Module defaultModule = new Module("4-4-2");
        private int numbofPlayers = 0;


        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public int NumbOfPlayers
        {
            //set { }
            
            get 
            { 
                return players.Count;
            }
        }

        public Team(string t)
        {
            teamName = t;
            players = new List<Player>();
        }


        public void setCoach(Coach c){
            coach = c;
        }

        public void addPlayer(Player p)
        {
            players.Add(p);
        }

        public void addPlayers(List<Player> lp)
        {
            this.players = lp;
        }

        public int Avg
        {
            get
            {
                int tot = 0;
                foreach (Player item in players)
                {
                    tot += item.SkillAvg;
                }
                tot = (tot / players.Count);
                avg = tot;
                return tot;
            }
            /*set
            {
                avg = value;
            }*/
        }

        public int getAvgTeam()
        {
            int tot = 0;
            foreach (Player player in players)
            {
                tot += player.SkillAvg;
            }
            
            tot = tot / players.Count; //fino a qui media giocatori

            //influenza dell'allenatore
            if (coach != null)
            {
                if (coach.SkillAvg >= tot)
                {
        //            Console.WriteLine("Bonus allenatore: +" + ((coach.SkillAvg - tot) / 2).ToString() );
                    tot += ((coach.SkillAvg - tot) / 2);
                }
                else
                {
        //            Console.WriteLine("Malus allenatore: " + ((coach.SkillAvg - tot) / 2).ToString());
                    tot += ((coach.SkillAvg - tot) / 2);
                }
                Module current = coach.FavouriteModule;
                if (current.check(this)) 
                {
        //            Console.WriteLine("Bonus modulo: +5");
                    tot += 5;
                }
                else
                {
      //              Console.WriteLine("Malus modulo: -5");
                    tot -= 5;
                }
            }
            else
            {
                Module current = defaultModule;
                if (current.check(this))
                {
       //             Console.WriteLine("Bonus modulo: +2");
                    tot += 2;
                }
                else
                {
       //             Console.WriteLine("Malus modulo: -6");
                    tot -= 6;
                }
            }

            return tot;
        }

        public double getAvgVal()
        {
            double tot = 0;
            foreach (Player player in players)
            {
                tot += player.Val;
            }

            return Math.Round(tot / players.Count, 2);
        }

        public int[] getPlayersPerRoles()
        {
            if (coach != null)
            {
                Module m = coach.FavouriteModule;
                int[] plfr =Module.playersForRolesinTeam(this);
                return plfr;
            }
            throw new InvalidOperationException("There is no Coach");
        }


        public override string ToString()
        {
           // string result = TeamName+" \n";
            string result = "";
        /*    foreach (Player player in players)
            {
                result += player.ToString() +"\n";
            }
         * */
            result += "media: " + Avg.ToString();// +"\n";
            result += " media valore: " + getAvgVal().ToString() + "M €";
            return result;

        }


        public Player getScorer()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();

            while (true)
            {
                Player scorer = players.ElementAt(rnd.getInt(NumbOfPlayers));
                if (scorer.Role != "PT")
                    return scorer;
            }

        }

        internal Player getPlayer(int i)
        {
            return players.ElementAt(i);
        }

        public string ToStringFull()
        {
            string result = TeamName+" \n";
            if (coach != null) result += "all: " + coach.ToString()+"\n";
            
                foreach (Player player in players)
                {
                    result += player.ToString() +"\n";
                }
            result += "media: " + Avg.ToString();// +"\n";
            result += " media valore: " + getAvgVal().ToString() + "M €";
            return result;
        }

        internal List<Player> getPlayers()
        {
            return players;
        }


    
        public int CompareTo(object obj)
        {
            Team other = (Team) obj;
            if (this.Avg >+ other.Avg)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
}
}

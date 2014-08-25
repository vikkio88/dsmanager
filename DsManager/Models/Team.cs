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
        public List<Player> players;
        public Coach coach = null;
        private int avg;
        private Module defaultModule = new Module("4-4-2");
        private int numbofPlayers = 0;

        //for gaming porpouse
        public bool isplayers = false;
        //



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

        public double getAvgAge()
        {
            double tot = 0;
      
            foreach (Player player in players)
            {
                tot += player.Age;
              
            }

            return Math.Round((tot / players.Count), 2);
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
            result += " media valore: " + getAvgVal().ToString() + "M Euro";
            return result;

        }


        public Player getScorer()
        {
            return GameUtils.getScorer(this);
        }

        public Player getPlayer(int i)
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

        public List<Player> getPlayers()
        {
            return players;
        }

        public Player getPlayerForRole(string role)
        {
            List<string> roles = new List<string>(){ "PT", "DC", "DD", "DS", "CC", "CD", "CS", "AD", "AS", "AC" };
            if (roles.IndexOf(role)<0)
            {
                throw new InvalidOperationException("Not a valid Role");
            }

            foreach (Player pl in players)
            {
                if (pl.Role == role)
                {
                    return pl;
                }
            }

            throw new Exception("No Player for this Role");
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



        public void rmPlayer(int i)
        {
            players.RemoveAt(i);
        }

        public Player popPlayerAt(int i)
        {
            Player temp = getPlayer(i);
            rmPlayer(i);
            return temp;
        }

        public Player popPlayer(Player pl)
        {
            return popPlayerAt(players.IndexOf(pl));
        }

        public void rmPlayer(Player pl)
        {
            players.Remove(pl);
        }

        public Coach getCoach()
        {
            return this.coach;
        }
    }
}

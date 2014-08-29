using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public class Match
    {
        #region FieldProp
        private Team homeTeam;
        private Team awayTeam;
        private int goalHome;
        private int goalAway;
        bool played = false;
        MatchResult result;

        public Team HomeTeam
        {
            get { return this.homeTeam; }
           // set {this.homeTeam = value; }
        }
        public Team AwayTeam
        {
            get { return this.awayTeam; }
          //  set { this.awayTeam = value; }
        }

        public MatchResult Result
        {
            get
            {
                if (!played)
                {
                    return Score();
                }
                else
                {
                    return result;
                }
            }
        }

        #endregion

        #region Ctor
        public Match(Team a, Team b)
        {
            homeTeam = a;
            awayTeam = b;
        }
        #endregion

        public MatchResult Score()
        {
            if (!played) { 
               
                this.Simulate();
               
                played = true;
            }
    

            MatchResult res = new MatchResult(this.goalHome, this.goalAway);
            res.Goals(homeTeam, awayTeam);
            
            result = res;

            return res;

        }
        public Team Winner()
        {
            if (played)
            {
                if (goalHome > goalAway)
                {
                    return HomeTeam;
                }
                return AwayTeam;
            }
            else
            {
                throw new InvalidOperationException("Partita non ancora giocata");
            }
        }
        public Team Loser()
        {
            if (played)
            {
                if (goalHome < goalAway)
                {
                    return HomeTeam;
                }
                return AwayTeam;
            }
            else
            {
                throw new InvalidOperationException("Partita non ancora giocata");
            }
        }

        public bool Draw()
        {
            if (played)
            {
                if (goalAway == goalHome) return true;
                return false;
            }
            else
            {
                throw new InvalidOperationException("Partita non ancora giocata");
            }
        }

        public void Penalties()
        {
            if (Draw())
            {
                
                RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
                if (rnd.getInt(100) > 50)
                {
                    goalHome += 1;
                }
                else
                {
                    goalAway += 1;
                }
            }
        }

        private void Simulate()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            int homepoints = HomeTeam.getAvgTeam();
            int awaypoints = AwayTeam.getAvgTeam();
            int c = rnd.getInt(100);
            if (c > 20)
            {
                //Console.WriteLine("risultato normale");
                int diff = (homepoints - awaypoints);
                if (diff < 0)
                {
                    goalAway = (awaypoints - homepoints) % 6;
                    goalHome = 0;
                    goalHome += chance();
                    goalAway += chance();
                    goalHome += bonusHome();
                }
                else
                {
                    goalHome = (homepoints - awaypoints) % 6;
                    goalAway = 0;
                    goalAway += chance();
                    goalHome += bonusHome();
                }
            }
            else
            {
                //Console.WriteLine("risultato nel 30%");
                goalHome = 0;
                goalAway = 0;
                goalHome += chance();
                goalAway += chance();
                goalHome += bonusHome();
            }

            //Influenza etá
            if (homeTeam.getAvgAge() > 29) { goalHome += bonusHome(); }
            if (awayTeam.getAvgAge() > 29) { goalAway += bonusHome(); }

            if (homeTeam.getAvgAge() < 24) { goalHome += bonusHome(); }
            if (awayTeam.getAvgAge() < 24) { goalAway += bonusHome(); }

            //influenza portiere HOME
            Player tmp;
            try 
	        {	        
		        tmp = homeTeam.getPlayerForRole("PT");
	        }
	        catch (Exception)
	        {
		
		        tmp = new Player("noone","",1,10,"");
	        }

            if (rnd.getInt(0, 100) > (100 - tmp.SkillAvg))
            {
                //Console.WriteLine("paratona HOME! "+tmp.SkillAvg);
                goalAway -= 1;
                if (goalAway < 0) goalAway = 0;
            }

            //Influenza Portiere AWAY
            try
            {
                tmp = awayTeam.getPlayerForRole("PT");
            }
            catch (Exception)
            {

                tmp = new Player("", "", 1, 10, "");
            }

            if (rnd.getInt(0, 100) > (100 - tmp.SkillAvg))
            {
               // Console.WriteLine("paratona AWAY! " + tmp.SkillAvg);
                goalHome -= 1;
                if (goalHome < 0) goalHome = 0;
            }

            //Influenza Campione
            //EVENTUALMENTE se ci fosse un giocatore sulla 95ina potremmo dargli un goal bonus



            GameUtils.wait();

        }

        private int chance()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            return rnd.getInt(0, 3);
        }

        private int bonusHome()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            GameUtils.wait();
            if (rnd.getInt(0, 100) > 66)
            {
               // Console.WriteLine("Ottenuto Goal Home bonus");
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            if (played)
            {
                return string.Format(HomeTeam.TeamName + " " + goalHome + " - " + goalAway + " " + AwayTeam.TeamName);
            }
            else
            {
                return HomeTeam.TeamName+" - "+AwayTeam.TeamName+" Match not played yet";
            }
        }


    }
}

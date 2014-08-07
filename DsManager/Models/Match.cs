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
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            this.Simulate(rnd);
            MatchResult res = new MatchResult(this.goalHome, this.goalAway);
            res.Goals(homeTeam, awayTeam);
            return res;
        }

        private void Simulate(RandomFiller.RandomFiller rnd)
        {
            
            int c = rnd.getInt(100);
            if (c > 35)
            {
                //Console.WriteLine("risultato normale");
                int diff = (HomeTeam.getAvgTeam() - AwayTeam.getAvgTeam());
                if (diff < 0)
                {
                    goalAway = (AwayTeam.getAvgTeam() - HomeTeam.getAvgTeam()) % 6;
                    goalHome = 0;
                    goalHome += chance();
                    goalAway += chance();
                    goalHome += bonusHome();
                }
                else
                {
                    goalHome = (HomeTeam.getAvgTeam() - AwayTeam.getAvgTeam()) % 6;
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

        }

        private int chance()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            return rnd.getInt(0, 3);
        }

        private int bonusHome()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            if (rnd.getInt(0, 100) > 66)
            {
               // Console.WriteLine("Ottenuto Goal Home bonus");
                return 1;
            }
            return 0;
        }


    }
}

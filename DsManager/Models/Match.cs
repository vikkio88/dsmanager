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
            this.Simulate();
            return new MatchResult(this.goalHome, this.goalAway);
        }

        private void Simulate()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            if (rnd.getInt(100) > 30)
            {
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
            return rnd.getInt(0, 2);
        }

        private int bonusHome()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            if (rnd.getInt(0, 100) > 66) return 1;
            return 0;
        }


    }
}

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

        public MatchResult(int p1, int p2)
        {
            // TODO: Complete member initialization
            this.goalHome = p1;
            this.goalAway = p2;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}",this.goalHome.ToString(),this.goalAway.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsManager.Models
{
    public class Coach
    {
        private string coachName;
        private string coachSurname;
        private int skillAvg;
        private Module favouriteModule;

        public int SkillAvg
        {
            get { return skillAvg; }
            set { skillAvg = value; }
        }


        public string CoachSurname
        {
            get { return coachSurname; }
            set { coachSurname = value; }
        }


        public string CoachName
        {
            get { return coachName; }
            set { coachName = value; }
        }
    }
}

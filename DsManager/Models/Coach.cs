using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsManager.Models
{
    public class Coach
    {
        #region Fields&Props
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

        public Module FavouriteModule
        {
            get { return favouriteModule; }
        }

        public string FavouriteModuleString
        {
            get { return favouriteModule.ToString();}
            set { favouriteModule = new Module(value);}
        }
        #endregion

        #region CTOR
        public Coach(string n, string s, int sk, string m)
        {
            CoachName = n;
            CoachSurname = s;
            SkillAvg = sk;
            favouriteModule = new Module(m);
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return string.Format("{0} {1} : skill {2} : modulo {3}",CoachName,CoachSurname,SkillAvg,favouriteModule.ToString());
        }
        #endregion


        public string ToStringShort()
        {
            return string.Format("{0} {1}", coachName, coachSurname);
        }
    }
}

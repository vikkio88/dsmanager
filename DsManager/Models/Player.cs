using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsManager.Models
{
    public class Player
    {
        #region Field&props
        private string playerName;
        private string playerSurname;
        private int age;
        private int skillAvg;
        private double val = 0;

        public int SkillAvg
        {
            get { return skillAvg; }
            set { skillAvg = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string PlayerSurname
        {
            get { return playerSurname; }
            set { playerSurname = value; }
        }
        

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public double Val{
            set{this.val = this.CalculateVal();}
            get{
                if(this.val==0) return this.CalculateVal();
                return this.val;
                }
        }

        private double CalculateVal()
        {
            double temp=0;
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            temp = priceOnSkill();
            temp = temp * (1 + onAgeModifier());
            temp += rnd.getInt(1, 3);
            temp -= rnd.getInt(1, 3);
            
            if (temp < 0) temp = 0.1;
            if (temp > 130) temp = 130;


            return temp;
        }

        private double priceOnSkill()
        {
            if (SkillAvg > 98) return 130.0;
            if (SkillAvg > 90) return 80.0;
            if (SkillAvg > 80) return 50.0;
            if (SkillAvg > 76) return 20.0;
            if (SkillAvg > 70) return 10.0;
            if (SkillAvg > 60) return 5.0;
            if (SkillAvg > 50) return 2.0;
            return 0.5;

        }

        private double onAgeModifier()
        {
            if (Age > 35) return -0.5;
            if (Age > 30) return -0.2;
            if (Age > 28) return -0.1;
            if (Age > 26) return 0.1;
            if (Age > 22) return 0.2;
            if (Age > 20) return 0.3;
            return 0.5;
        }
        #endregion


        public override string ToString()
        {
            return string.Format("{0} {1}, etá {3} : media {2}% : prezzo {4}M €", PlayerName, PlayerSurname, SkillAvg.ToString(),Age.ToString(),Val.ToString());
        }
        
    }
}

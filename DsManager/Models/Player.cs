using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DsManager.Models
{
    public class Player
    {
        #region Field&props
        private string playerName;
        private string playerSurname;
        private int age;
        private int skillAvg;
        private string nationality;
        private double val = 0;
        private string role;

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

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public double Val{
           // set{this.val = this.CalculateVal();}
            get{
                if(this.val==0) return this.CalculateVal();
                return this.val;
                }
        }

        public string Role
        {
            set { this.role = value; }
            get{return this.role;}
        }


        #endregion

        #region Ctor
        public Player()
        {

        }

        public Player(string line) //string must have this sintax Name:Surname:Age:Skill:Role:Nation
        {
            System.Text.RegularExpressions.Match m = Regex.Match(line,@"^(.+?):(.+?):(.+?):(.+?):(.+?):(.+?)\b");

            if(m.Success){
                //Console.WriteLine(m.Value);
                int c = 0;
                foreach (System.Text.RegularExpressions.Group s in m.Groups)
                {
                    if (c != 0) 
                    {
                        if (c == 1) this.playerName = s.Value;
                        if (c == 2) this.playerSurname = s.Value;
                        if (c == 3) this.age = int.Parse(s.Value);
                        if (c == 4) this.SkillAvg = int.Parse(s.Value);
                        if (c == 5) this.role = s.Value;
                        if (c == 6) this.nationality = s.Value;
                    }
                    
                    c++;
                }
            }
            else
            {
                throw new InvalidOperationException("Not a valid String to build a Player");
            }

        }
        public Player(string n, string s, int a, int skill,string r, string nation = "Italiano")
        {
            this.PlayerName = n;
            this.PlayerSurname = s;
            this.Age = a;
            this.SkillAvg = skill;
            this.Role = r;
            this.Nationality = nation;
        }
        #endregion


        private double CalculateVal()
        {
            double temp = 0;
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            temp = priceOnSkill();
            temp = temp * (1 + onAgeModifier());
            temp += rnd.getInt(1, 3);
            temp -= rnd.getInt(1, 3);

            //Modificatori prezzo sul Ruolo
            if (Role != null)
            {
                if (this.Role == "AC")
                {
                    temp += rnd.getInt(0, 4);

                }
                else if (this.Role == "AS")
                {
                    temp += rnd.getInt(0, 2);
                }
                else if (this.Role == "AD")
                {
                    temp += rnd.getInt(0, 2);
                }
                else if (this.Role == "CC")
                {
                    temp += rnd.getInt(0, 3);
                }
                else if (this.Role == "DC")
                {
                    temp += rnd.getInt(0, 2);
                }
            }
            //

            //Modificatori spiccioli
            if (rnd.getInt(100) > 50)
            {
                temp += (rnd.getInt(1, 5) / 10.0);
            }
            else
            {
                temp -= (rnd.getInt(1, 5) / 10.0);
            }
            //

            if (temp <= 0) temp = 0.1;
            if (temp > 130) temp = 130;

            temp = Math.Round(temp,2);
            this.val = temp;

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
            if (Age > 32) return -0.5;
            if (Age > 30) return -0.2;
            if (Age > 28) return -0.1;
            if (Age > 26) return 0.1;
            if (Age > 22) return 0.2;
            if (Age > 20) return 0.3;
            return 0.5;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}, etá {3} : media {2}% : ruolo {5} : prezzo {4}M E", PlayerName, PlayerSurname, SkillAvg.ToString(),Age.ToString(),Val.ToString(),Role);
        }


        public string ToStringShort()
        {
            return playerName + " " + playerSurname;
        }
    }
}

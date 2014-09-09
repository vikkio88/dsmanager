using DsManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDSSimulator
{
    public partial class SpeakWithCoachForm : Form
    {
        static Coach c;
        static Team playersteam;
        public SpeakWithCoachForm()
        {
            InitializeComponent();
        }

        private void SpeakWithCoachForm_Load(object sender, EventArgs e)
        {
            Program.formFixing(this);

            playersteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);
            c = playersteam.coach;
            txtCoachInfo.Text = c.ToString();
            AddTeamInfo();
            
            txtCoachWords.Text = c.CoachName+" : Hello mr " + MainForm.playername + ", I heard you wanted to talk with me... what is the matter?";

            btnGoodJob.Focus();
        }

        public int goingWell()
        {
            int goingwellperc = 100;

            int round = MainForm.l.CurrentRound;
            int won = MainForm.vps[0];
            int draw = MainForm.vps[1];
            int lost = MainForm.vps[2];
            int position = MainForm.l.getPositionbyTeamName(playersteam.TeamName);
            int numbofteam = MainForm.l.NumbOfTeam;

            if (!(won > draw && won > lost))
            {
                goingwellperc -= 40;
            }
            else if (draw > won)
            {
                goingwellperc -= 30;
            }
            else if (lost > won && lost > draw)
            {
                goingwellperc -= 55;
            }

            goingwellperc -= ((position / numbofteam * 100) - 100);

            if (goingwellperc > 100) goingwellperc = 100;


            return goingwellperc;
        }

        public void AddTeamInfo()
        {
      
            string[] m = Module.getRoles().ToArray();
            int[] n1 = Module.playersForRolesinTeam(playersteam);
            int length = n1.Count();
            string teamplayerperrole = "";
            string moduleplayerperrole = "";
            for (int i = 0; i < length; i++)
            {
               // Console.Write(m[i] + ": " + n1[i].ToString() + " ");
                // if (!reportstringready)
                // {
                teamplayerperrole += m[i] + ": " + n1[i].ToString() + " ";
                //}
            }
            int[] n = playersteam.coach.FavouriteModule.playerForRolesForModule();

            int length1 = n.Count();
            for (int i = 0; i < length1; i++)
            {
                if (n[i] != 0)
                {
                   
                        moduleplayerperrole += m[i] + ": " + n[i].ToString() + " ";
                    
                }
            }

            txtCoachInfo.Text += "\r\nTeam Info:\r\n"+playersteam.TeamName + "\r\nAvgAge: " + playersteam.getAvgAge() + "\r\nAvgSkill: " + playersteam.Avg + "\r\nplayers needed for coach module: \r\n" + moduleplayerperrole + "\r\nplayers per role in Team: \r\n" + teamplayerperrole;

        
        }

        private void btnGoodJob_Click(object sender, EventArgs e)
        {
            nullOtherAction();

            txtCoachWords.Text += "\r\n" + MainForm.playername + " : I just wanted to say you that you are doing a good job" + "\r\n";
            if (MainForm.l.CurrentRound > 1)
            {
                if (GameUtils.getProbability(goingWell()))
                {
                    txtCoachWords.Text += c.CoachName + " : Thanks, doing my best!";
                    c.SkillAvg += 1;
                }
                else
                {
                    txtCoachWords.Text += c.CoachName + " : Well, I dont agree at all!";
                    c.SkillAvg -= 2;
                }
            }
            else //not enough match to give a positive judgment
            {
                txtCoachWords.Text += c.CoachName + " : Is too early, I hate compliments for no reason!";
                c.SkillAvg -= 5;
            }
        }

        private void nullOtherAction()
        {
            btnChangeModule.Enabled = false;
            btnFireCoach.Enabled = false;
            btnGoodJob.Enabled = false;
            btnIwantMore.Enabled = false;

            btnQuit.Visible = true;
        }

        private void btnIwantMore_Click(object sender, EventArgs e)
        {
            nullOtherAction();

            txtCoachWords.Text += "\r\n" + MainForm.playername + " : I need to see more!" + "\r\n";
            if (MainForm.l.CurrentRound > 1)
            {
                if (!(GameUtils.getProbability(goingWell())))
                {
                    txtCoachWords.Text += c.CoachName + " : I will try to improve! Promise!";
                    c.SkillAvg += 2;
                }
                else
                {
                    txtCoachWords.Text += c.CoachName + " : Well, I dont agree at all with you! That is not my fault!";
                    c.SkillAvg -= 3;
                }
            }
            else //not enough match to give a positive judgment
            {
                txtCoachWords.Text += c.CoachName + " : Is too early, I hate to work underpressure!";
                c.SkillAvg -= 5;
            }

        }

        private void btnChangeModule_Click(object sender, EventArgs e)
        {
            nullOtherAction();
            txtCoachWords.Text += "\r\n" + MainForm.playername + " : I just wanted to suggest you to change module"+"\r\n";
            if (MainForm.l.CurrentRound > 1)
            {
                if (!(GameUtils.getProbability(goingWell())))
                {
                    txtCoachWords.Text += c.CoachName + " : Well, we are not going that well after all... let me think...";
                    c.FavouriteModule = GameUtils.getRandomCoach().FavouriteModule;
                    txtCoachWords.Text += c.CoachName + " : I think the best module will be "+c.FavouriteModuleString;
                }
                else
                {
                    txtCoachWords.Text += c.CoachName + " : Well, I dont agree at all! I am the coach here and I know what module suits better my team!";
                    c.SkillAvg -= 4;
                }
            }
            else //not enough match to give a positive judgment
            {
                txtCoachWords.Text += c.CoachName + " : Is too early to think about that, let me do my job!";
                c.SkillAvg -= 5;
            }

        }

        private void btnFireCoach_Click(object sender, EventArgs e)
        {
            nullOtherAction();

            double rescissione = GameUtils.getWage(1,3);
            MainForm.money -= rescissione;
            if(MainForm.money<0) MainForm.money = 0;
            txtCoachWords.Text += "\r\n" + MainForm.playername + " :  I want to inform you that your your services are no longer required by the team, goodbye!";

           MessageBox.Show("*** you paid " + rescissione + " M € to terminate the contract");

            playersteam.coach = GameUtils.getRandomCoach();
            MessageBox.Show("*** Presindent hired "+playersteam.coach.ToStringShort()+" as new coach","Information");
            this.Close();
           // txtCoachWords.Text += "\r\n *** Presindent hired "+playersteam.coach.ToStringShort()+" as new coach";

            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}

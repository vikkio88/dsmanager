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
    public partial class PressConferenceForm : Form
    {
        public static string jn;
        public static string newspaper;
        public static string pln = MainForm.playername;
        public static bool sayedsomething = false;
        public static bool goodaboutteam = false;
        public static bool goodaboutplayer = false;
        public static string player;
        public static int playerindex;
        public static Team plteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);

        public PressConferenceForm()
        {
            InitializeComponent();
        }

        private void PressConferenceForm_Load(object sender, EventArgs e)
        {
            Program.formFixing(this);
            fillCbo();
            jn = GameUtils.getRandomCoach().ToStringShort();
            newspaper = GameUtils.getRandomNewsPaperName();
            sayedsomething = false;
            goodaboutteam = false;
            goodaboutplayer = false;
            player = "";
            playerindex = -1;

            Answer("Hello mr " + pln+", "+jn+" from "+newspaper+" here, you want to do any declaration?");


            

        }

        private void fillCbo()
        {
            foreach (Player pl in MainForm.l.getTeambyTeamName(MainForm.playerteam).players)
            {
                cboPlayers.Items.Add(pl.ToStringShort());
                cboPlayers.SelectedIndex = 0;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoodJobTeam_Click(object sender, EventArgs e)
        {
            grpTeam.Enabled = false;
            Say("well, I just wanted to say that my team is doing well, and I am happy about my boys!");
            Answer("Ok, thank you, anything else?");

            goodaboutteam = true;
            sayedsomething = true;

        }

        private void btnBadJobTeam_Click(object sender, EventArgs e)
        {
            grpTeam.Enabled = false;
            Say("well, I just wanted to say that my team is not playing as good as I expected, and I am not happy about it!");
            Answer("Ok, thank you, anything else?");

            goodaboutteam = false;
            sayedsomething = true;

        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            btnGoodbye.Enabled = false;
            grpTeam.Enabled = false;
            grpPlayer.Enabled = false;
            btnQuit.Enabled = true;

            if (sayedsomething)
            {
                Say("No, nothing more...");
            }
            else
            {
                Say("No, not at all...sorry");
            }

            Say("Goodbye and thanks");
            Answer("Thank you mr "+MainForm.playername);

            calculateReactions();
        }



        private void Answer(string p)
        {
            txtPress.AppendText(jn + " :\r\n" + p + "\r\n\r\n");
        }

        private void Say(string p)
        {
            txtPress.AppendText(pln + " :\r\n" + p + "\r\n\r\n");
        }

        private void btnGoodJobPlayer_Click(object sender, EventArgs e)
        {
            grpPlayer.Enabled = false;
            player = cboPlayers.SelectedItem.ToString();
            playerindex = cboPlayers.SelectedIndex;
            Say("well, I wanted to say that "+player+" is playing really well, and I am happy that He's part of our team...");
            Answer("Ok, thank you, anything else?");

            goodaboutplayer = true;
            sayedsomething = true;


        }

        private void btnBadobPlayer_Click(object sender, EventArgs e)
        {
            grpPlayer.Enabled = false;
            player = cboPlayers.SelectedItem.ToString();
            playerindex = cboPlayers.SelectedIndex;
            Say("well, I wanted to say that " + player + " is not playing as well as He can, and I am a bit concerned about that...");
            Answer("Ok, thank you, anything else?");

            goodaboutplayer = false;
            sayedsomething = true;
        }


        private void calculateReactions()
        {
            if (playerindex != -1) //hai parlato del giocatore
            {
                if (goodaboutplayer)//hai parlato bene del giocatore
                {
                    Player temp = plteam.getPlayer(playerindex);
                    if (GameUtils.getProbability(50))
                    {
                        temp.SkillAvg += 1;
                        Cons(player+" is happy about your declaration");
                    }
                    else
                    {
                        temp.SkillAvg -= 2;
                        Cons(player + " is not happy about your declaration");

                    }

                }
                else// hai parlato male del giocatore
                {
                    Player temp = plteam.getPlayer(playerindex);
                    if (GameUtils.getProbability(40))
                    {
                        temp.SkillAvg += 3;
                        Cons(player + " want to improve his performance");
                    }
                    else
                    {
                        temp.SkillAvg -= 4;
                        Cons(player + " seems really pissed off about your declaration");

                    }

                }

            }

            if (sayedsomething)
            {

                if (goodaboutteam)// hai parlato bene della squadra
                {

                    if (GameUtils.getProbability(70))
                    {
                        plteam.coach.SkillAvg += 1;
                        Cons("the Coach, " + plteam.coach + "  is happy about your declaration");
                    }
                    else
                    {
                        plteam.coach.SkillAvg -= 1;
                        Cons("the Coach, " + plteam.coach + " is not happy about your declaration");

                    }
                }
                else// hai parlato male della squadra o non hai parlato per niente
                {
                    if (GameUtils.getProbability(40))
                    {
                        plteam.coach.SkillAvg += 3;
                        Cons("the Coach, " + plteam.coach + "  want to improve team performace after your declaration");
                    }
                    else
                    {
                        plteam.coach.SkillAvg -= 2;
                        Cons("the Coach, "+plteam.coach + " is not happy about your declaration");

                    }

                }
            }
            else
            {
                Cons("You didnt any declaration, no reaction in your team...");
            }
        }

        private void Cons(string p)
        {
            txtCons.AppendText(p+"\r\n\r\n");
        }
    }
}

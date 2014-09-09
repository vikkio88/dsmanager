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

namespace WinFormDSSimulator.marketDialogForms
{
    public partial class TryToSellPlayerForm : Form
    {
        static Player tosell;
        static double off;
        static Team other;
        static List<string> teamnames = new List<string>();
        static Team playerteam;

        static int constant = 43; //constant for selling stuff
        public TryToSellPlayerForm(Player p)
        {
            tosell = p;
            playerteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);
            
            foreach (Team t in MainForm.l.leagueTeams)
            {
                if (t.isplayers != true)
                {
                    teamnames.Add(t.TeamName);
                }
            }

            InitializeComponent();
        }

        private void TryToSellPlayerForm_Load(object sender, EventArgs e)
        {
            Program.formFixing(this);




            Random rnd = new Random();
            double probabilitytosell = constant + (100 - (tosell.Age / 40.0 * 100));
            if (GameUtils.getProbability(Convert.ToInt32(probabilitytosell))) // probabilitá di vendere giocatore legata all'etá
            {
                int c = evaluatePlayer(tosell);
                off = Math.Round((tosell.Val + (tosell.Val * (c / 100.0))),2);
                other = MainForm.l.getTeambyTeamName(teamnames.ElementAt(rnd.Next(0, teamnames.Count)));
                txtOffer.Text = other.TeamName + " offer " + off + " M € for this Player";

            }
            else
            {
                txtOffer.Text = "No offers for this Player";
                btnAccept.Enabled = false;
                btnReject.Enabled = false;
                button1.Visible = true;
            }

            txtPlayerInfo.Text = tosell.ToString();
        }

        private int evaluatePlayer(Player tosell)
        {
            double perc = 100;
           // Console.WriteLine("step1: " + perc);
            perc -= (100 - tosell.SkillAvg);
           // Console.WriteLine("onskill: " + perc);
            perc -= ((tosell.Age / 40.0 * 100));
           // Console.WriteLine("\tmodifier: " + (tosell.Age / 40.0 * 100));
            //Console.WriteLine("onage: " + perc);


            return Convert.ToInt32(perc);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            callbackround();
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            other.addPlayer(playerteam.popPlayer(tosell));
            MainForm.money += off;
            MessageBox.Show(tosell.ToStringShort() + " sold to " + other.TeamName + " for " + off + " M €", "Success");


            callbackround();
           
        }

        private void callbackround()
        {
            var previousform = Application.OpenForms.OfType<MarketSummer>().Single();
            previousform.RoundFinished();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callbackround();
        }
    }
}

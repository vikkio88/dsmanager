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
    public partial class Offer : Form
    {
        static Player tosell;
        static double off;
        static Team other;
        static List<string> teamnames = new List<string>();
        static Team playerteam;

        public Offer()
        {
            Random rnd = new Random();
            playerteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);

            foreach (Team t in MainForm.l.leagueTeams)
            {
                if (t.isplayers != true)
                {
                    teamnames.Add(t.TeamName);
                }
            }

            other = MainForm.l.getTeambyTeamName(teamnames.ElementAt(rnd.Next(teamnames.Count)));
            tosell = playerteam.getPlayer(rnd.Next(playerteam.NumbOfPlayers));

            InitializeComponent();
        }

        private void Offer_Load(object sender, EventArgs e)
        {
            Program.formFixing(this);



            off = tosell.Val;
            off += GameUtils.getWage(0, 10);
            txtPlayerInfo.Text = tosell.ToString();
            txtOffer.Text = other.TeamName + " offer " + off + " M € for this Player";

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
    }
}

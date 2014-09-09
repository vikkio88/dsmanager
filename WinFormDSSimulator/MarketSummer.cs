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
using WinFormDSSimulator.marketDialogForms;

namespace WinFormDSSimulator
{
    
    public partial class MarketSummer : Form
    {
        static Team playersteam;
        static int currentround = 1;
        static int numbofround = 15;
        public MarketSummer()
        {
            InitializeComponent();
        }

        private void btnMyTeam_Click(object sender, EventArgs e)
        {
            pnlMainMarket.Visible = true;
        }

        private void MarketSummer_Load(object sender, EventArgs e)
        {
            currentround = 0;


            string coachreport = GameUtils.CheckCoachWorkString(MainForm.l);
            txtEvents.Text += coachreport + "\r\n";

            string agingreport = GameUtils.AgePlayersString(MainForm.l);
            txtEvents.Text += agingreport+"\r\n";

            string randommarketreport = GameUtils.CalciomercatoRandomString(MainForm.l);
            txtEvents.Text += randommarketreport;

            playersteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);

            

            FillTeamInfo();
            FillLst(playersteam);

        }

        private void removefromcborole(string role)
        {
            cboRole.Items.Remove(role);
        }

        private void pnlMainMarket_Paint(object sender, PaintEventArgs e)
        {
            //ricorda di chiamare fillLst quando compri un giocatore

        }

        private void FillTeamInfo()
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

            
            txtTeamInfo.Text = playersteam.TeamName + "\r\n balance:"+MainForm.money+" M €\r\ncoach: " + playersteam.coach.ToString() + "\r\nAvgAge: " + playersteam.getAvgAge() + "\r\nAvgSkill: " + playersteam.Avg + "\r\nplayers needed for coach module: \r\n" + moduleplayerperrole + "\r\nplayers per role in Team: \r\n" + teamplayerperrole;

        }

        private void FillLst(Team playersteam)
        {
            List<string> pls = new List<string>();

            foreach (Player pl in playersteam.players)
            {
                pls.Add(pl.ToStringShort() + " " + pl.Role);
            }

            lstPlayers.DataSource = pls;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ListSelectEvent(object sender, EventArgs e)
        {
            //cboRole.DataSource = Module.getRoles().ToArray();
            fillCborole();
            //showme(lstTeams.SelectedItem.ToString());
            txtPlayerInfo.Text = playersteam.getPlayer(lstPlayers.SelectedIndex).ToString() + "\r\n";
            removefromcborole("PT");
            removefromcborole(playersteam.getPlayer(lstPlayers.SelectedIndex).Role);
            //txtTeamInfo.Text = MainForm.l.getTeambyTeamName(lstTeams.SelectedItem.ToString()).ToStringFull();
        }

        private void fillCborole()
        {
            cboRole.Text = "";
            cboRole.Items.Clear();
            string[] roles = Module.getRoles().ToArray();

            foreach (string item in roles)
            {
                cboRole.Items.Add(item);
            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            if (cboRole.SelectedIndex != -1)
            {
                Player temp = playersteam.getPlayer(lstPlayers.SelectedIndex);
                if (temp.Age < 20)
                {
                    if (GameUtils.getProbability(70))
                    {
                        temp.Role = cboRole.SelectedItem.ToString();
                        MessageBox.Show("Now " + temp.ToStringShort() + " will play as " + temp.Role,"Success!");

                    }
                    else
                    {
                        MessageBox.Show(temp.ToStringShort() + " can't play in the new role", "Failure");
                    }

                }
                else
                {
                    if (GameUtils.getProbability(30))
                    {
                        temp.Role = cboRole.SelectedItem.ToString();
                        MessageBox.Show("Now " + temp.ToStringShort() + " will play as " + temp.Role, "Success!");

                    }
                    else
                    {
                        MessageBox.Show(temp.ToStringShort() + " can't play in the new role", "Failure");
                    }

                }

                RoundFinished(true);


            }
            else
            {
                MessageBox.Show("Select the new Role", "Error");
                cboRole.Focus();
            }
        }

        public void RoundFinished(bool addrandomoffer=false)
        {
            currentround++;
            refreshinfos();

            if (addrandomoffer)
            {
                RandomOffer();
            }

            if (currentround == 15)
            {
                MarketEnded();
            }
        }

        private void RandomOffer()
        {
            if (GameUtils.getProbability(60))
            {
                Offer of = new Offer();
                of.Show();
            }
        }

        private void MarketEnded()
        {
            MessageBox.Show("Market Ended!", "Info");
            this.Close();
        }

        private void refreshinfos()
        {
            FillTeamInfo();
            FillLst(playersteam);
            lblWeeks.Text = "Week " + currentround + "/" + numbofround;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            TryToSellPlayerForm ttspf = new TryToSellPlayerForm(playersteam.getPlayer(lstPlayers.SelectedIndex));
            ttspf.Show();
            //controllare fine di questo processo prima di
            //RoundFinished();
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            RoundFinished(true);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {

        }

        private void btnYouth_Click(object sender, EventArgs e)
        {

        }

        private void btnFreePlayers_Click(object sender, EventArgs e)
        {
            FreePlayersForm fpf = new FreePlayersForm();
            fpf.Show();
        }

        private void btnPlayerRole_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayersInLeague_Click(object sender, EventArgs e)
        {

        }



    }
}

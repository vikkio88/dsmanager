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
    public partial class MyTeamForm : Form
    {
        private static Team playersteam;
        public MyTeamForm()
        {
            InitializeComponent();
        }

        private void MyTeamForm_Load(object sender, EventArgs e)
        {
            this.Text = MainForm.playerteam + " Info";
            playersteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);

            FillLst(playersteam);
            FillTeamInfo();
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


            txtTeamInfo.Text = playersteam.TeamName + "\r\ncoach: "+playersteam.coach.ToString()+"\r\nAvgAge: " + playersteam.getAvgAge() + "\r\nAvgSkill: " + playersteam.Avg + "\r\nplayers needed for coach module: " + moduleplayerperrole + "\r\nplayers per role in Team: " + teamplayerperrole;

        }

        private void FillLst(Team playersteam)
        {
            List<string> pls = new List<string>();

            foreach (Player pl in playersteam.players)
            {
                pls.Add(pl.ToStringShort()+" "+pl.Role);
            }

            lstPlayers.DataSource = pls;
        }
        private void ListSelectEvent(object sender, EventArgs e)
        {
            //showme(lstTeams.SelectedItem.ToString());
            txtPlayerInfo.Text = playersteam.getPlayer(lstPlayers.SelectedIndex).ToString()+"\r\n";
            if (MainForm.l.scorers.ContainsKey(playersteam.getPlayer(lstPlayers.SelectedIndex)))
            {
                txtPlayerInfo.Text += "goals: " + MainForm.l.scorers[playersteam.getPlayer(lstPlayers.SelectedIndex)].goals;
            }
            
            //txtTeamInfo.Text = MainForm.l.getTeambyTeamName(lstTeams.SelectedItem.ToString()).ToStringFull();
        }
    }
}

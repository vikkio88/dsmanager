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
    public partial class YouthClubForm : Form
    {
        static List<Player> youthcl;
        static Team plteam;
        public YouthClubForm(List<Player> y)
        {
            youthcl = y;
            plteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);
            InitializeComponent();
        }

        private void YouthClubForm_Load(object sender, EventArgs e)
        {
            this.Text = plteam.TeamName + " Youth Club";
            fillList();
        }

        private void fillList()
        {
            foreach (Player pl in youthcl)
            {
                lstPlayers.Items.Add(pl.ToStringShort() + " role: " + pl.Role + " age: " + pl.Age + " skill: " + pl.SkillAvg);
            }
            
        }


        private void ListSelectEvent(object sender, EventArgs e)
        {
            //cboRole.DataSource = Module.getRoles().ToArray();

            //showme(lstTeams.SelectedItem.ToString());
            txtPlayerInfo.Text = youthcl.ElementAt(lstPlayers.SelectedIndex).ToString() + "\r\n";
            //txtTeamInfo.Text = MainForm.l.getTeambyTeamName(lstTeams.SelectedItem.ToString()).ToStringFull();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpeakWithPlayer swp = new SpeakWithPlayer(youthcl.ElementAt(lstPlayers.SelectedIndex));
            swp.Show();
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
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

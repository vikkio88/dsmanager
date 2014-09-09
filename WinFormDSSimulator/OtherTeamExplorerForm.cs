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
    public partial class OtherTeamExplorerForm : Form
    {
        public OtherTeamExplorerForm()
        {
            InitializeComponent();
        }

        private void OtherTeamExplorerForm_Load(object sender, EventArgs e)
        {
            Program.formFixing(this);
            TeamListToListBox(MainForm.l.leagueTeams, lstTeams);
        }

        private void ListSelectEvent(object sender, EventArgs e)
        {
            //showme(lstTeams.SelectedItem.ToString());
            txtTeamInfo.Text = MainForm.l.getTeambyTeamName(lstTeams.SelectedItem.ToString()).ToStringFull();
        }

        public void TeamListToListBox(List<Team> tl, ListBox lb)
        {

            List<string> teamnames = new List<string>();
            foreach (Team t in tl)
            {
                if (t.isplayers != true)
                {
                    teamnames.Add(t.TeamName);
                }
            }

            lb.DataSource = teamnames;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }
    }
}

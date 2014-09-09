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
    public partial class FreePlayersForm : Form
    {
        static List<Player> list;
        public FreePlayersForm()
        {
            InitializeComponent();
        }

        private void FreePlayersForm_Load(object sender, EventArgs e)
        {
            list = GameUtils.getRandomPlayersOLDList(20);
            AddPlayersToLst();          
        }



        private void ListSelectEvent(object sender, EventArgs e)
        {
            //cboRole.DataSource = Module.getRoles().ToArray();
          
            //showme(lstTeams.SelectedItem.ToString());
            txtPlayerInfo.Text = list.ElementAt(lstFreePlayers.SelectedIndex).ToString() + "\r\n";
            //txtTeamInfo.Text = MainForm.l.getTeambyTeamName(lstTeams.SelectedItem.ToString()).ToStringFull();
        }

        private void AddPlayersToLst()
        {
            foreach (Player pl in list)
            {
                lstFreePlayers.Items.Add(pl.ToStringShort()+" role: "+pl.Role+" age: "+pl.Age+" skill: "+pl.SkillAvg);
            }
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            SpeakWithPlayer swp = new SpeakWithPlayer(list.ElementAt(lstFreePlayers.SelectedIndex));
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

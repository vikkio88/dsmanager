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
    
    public partial class MarketSummer : Form
    {
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
            string coachreport = GameUtils.CheckCoachWorkString(MainForm.l);
            txtEvents.Text += coachreport + "\r\n";

            string agingreport = GameUtils.AgePlayersString(MainForm.l);
            txtEvents.Text += agingreport+"\r\n";

            string randommarketreport = GameUtils.CalciomercatoRandomString(MainForm.l);
            txtEvents.Text += randommarketreport;
        }
    }
}

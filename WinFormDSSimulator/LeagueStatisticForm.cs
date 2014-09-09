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
    public partial class LeagueStatisticForm : Form
    {
        public LeagueStatisticForm()
        {
            InitializeComponent();
        }

        private void LeagueStatisticForm_Load(object sender, EventArgs e)
        {
            Program.formFixing(this);
            

            txtTable.Text = MainForm.l.getScorerTable(MainForm.playerteam);

            btnQuit.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        public TryToSellPlayerForm(Player p)
        {
            tosell = p;
            InitializeComponent();
        }

        private void TryToSellPlayerForm_Load(object sender, EventArgs e)
        {
            txtPlayerInfo.Text = tosell.ToString();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

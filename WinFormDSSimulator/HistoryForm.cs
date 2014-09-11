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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            fillLeagueHistory();
            fillPlHistory();

            
        }

        private void fillPlHistory()
        {
            txtPlayerHistory.Text = "";
            foreach (string item in MainForm.albogiocatore)
            {
//                MessageBox.Show(item);

                txtPlayerHistory.Text += item+"\r\n\r\n";
            }
        }

        private void fillLeagueHistory()
        {
            txtLeagueHistory.Text = "Hall of Fame\r\n";
            foreach (string item in MainForm.albocampionato)
            {
                txtLeagueHistory.Text += item + "\r\n\r\n";
            }

            txtLeagueHistory.AppendText("ScorerTable Winners\r\n");
            foreach (string item in MainForm.albocannonieri)
            {
                txtLeagueHistory.Text += item + "\r\n";
            }

            btnQuit.Focus();

            
        }
    }
}

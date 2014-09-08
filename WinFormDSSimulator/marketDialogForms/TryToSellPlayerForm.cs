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
        static double off;
        static Team other;
        public TryToSellPlayerForm(Player p)
        {
            tosell = p;
            InitializeComponent();
        }

        private void TryToSellPlayerForm_Load(object sender, EventArgs e)
        {
            if (GameUtils.getProbability()) // probabilitá di vendere giocatore legata all'etá
            {
                int c = evaluatePlayer(tosell);
                off = Math.Round((tosell.Val + (tosell.Val * (c / 100.0))),2);
            }
            else
            {
                btnAccept.Enabled = false;
                btnReject.Enabled = false;
            }

            txtPlayerInfo.Text = tosell.ToString();
        }

        private int evaluatePlayer(Player tosell)
        {
            double perc = 100;
           // Console.WriteLine("step1: " + perc);
            perc -= (100 - tosell.SkillAvg);
           // Console.WriteLine("onskill: " + perc);
            perc -= ((tosell.Age / 40.0 * 100));
           // Console.WriteLine("\tmodifier: " + (tosell.Age / 40.0 * 100));
            //Console.WriteLine("onage: " + perc);


            return Convert.ToInt32(perc);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

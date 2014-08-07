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

namespace DsManager
{
    public partial class Form1 : Form
    {
        Team a = new Team("Baracca");
        public Form1()
        {
            

            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

                
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<Player> players = GameUtils.getRandomPlayersList(40);
            foreach (Player item in players)
            {
                playerBindingSource.Add(item);
            }

           
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Player selected = (Player)dataGridView1.CurrentRow.DataBoundItem;

            double money = double.Parse(lbl1.Text);

            if (money > selected.Val)
            {
                money -= selected.Val;
                lbl1.Text = Math.Round(money, 2).ToString();
                playerBindingSource.Remove(dataGridView1.CurrentRow.DataBoundItem);
                playerBindingSource1.Add(selected);
                RefreshTeam();
            }
            else
            {
                MessageBox.Show("Non hai abbastanza fondi per acquistare il giocatore selezionato");
            }

            //MessageBox.Show(selected.ToString());
        }

        private void RefreshTeam()
        {
            
            foreach (Player item in playerBindingSource1)
            {
                a.addPlayer(item);
            }
            label3.Text = a.ToString();
        }


        


    }
}

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
    public partial class SpeakWithPlayer : Form
    {
        public static Player playertobuy;
        public static int constant = 45;
        public static double off = 0;
        public static double controff = 0;
        public static Team playersteam;
        public SpeakWithPlayer(Player p) 
        {
            playertobuy = p;
            playersteam = MainForm.l.getTeambyTeamName(MainForm.playerteam);
            InitializeComponent();
        }

        private void SpeakWithPlayer_Load(object sender, EventArgs e)
        {
            
            txtPlayerInfo.Text = playertobuy.ToString();
            
            calculateWageRequest();

            txtOffer.Text = playertobuy.PlayerName + " : Hello mr " + MainForm.playername + ", to join your team I would like to have a wage of " + off + " M €";
        }

        private void calculateWageRequest()
        {
            int constant = 45;
            double probabilitytosell = constant + (100 - (playertobuy.Age / 40.0 * 100));
           // Console.WriteLine("pobtosell: " + (probabilitytosell - constant - 10));
            probabilitytosell -= constant - 10;
            off = playertobuy.Val * 0.05 + (playertobuy.Val * (probabilitytosell / 560.0));
            off = Math.Round(off, 2);
            if (off > 10) off = GameUtils.getWage(8, 10);
            //Console.WriteLine("req: " + off + " M €");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            controff = off;
            if (checkMoney())
            {
                Answer(sendControff(controff));
            }
        }

        private bool checkMoney()
        {
            if (controff > MainForm.money)
            {
                MessageBox.Show("You dont have enough money!", "Error");
                return false;
            }

            return true;
        }

        private void Answer(bool ans)
        {
            if (ans)
            {
                MessageBox.Show(playertobuy.ToStringShort() + " accepted the offer","Success");
                addPlayer();
            }
            else
            {
                MessageBox.Show(playertobuy.ToStringShort() + " declined your offer", "Failure");
            }

            //qui callback al form
            callbackround();

        }

        private void addPlayer()
        {
            MainForm.money -= controff;
            MainForm.l.getTeambyTeamName(MainForm.playerteam).addPlayer(playertobuy);
        }

        private bool sendControff(double controff)
        {
            if (controff >= off)
            {
                return true;
            }else{
                if (GameUtils.getProbability(Convert.ToInt32(controff / off * 100.0)))
                {
                    return true;
                }

                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpNewOffer.Enabled = true;
            btnChangeOffer.Enabled = false;
            btnAccept.Enabled = false;
            txtNewOff.Text = off.ToString();
            

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            controff = double.Parse(txtNewOff.Text);
            if (checkMoney())
            {
                Answer(sendControff(controff));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(txtNewOff.Text) + 1.0;
            temp = Math.Round(temp, 2);
            txtNewOff.Text = temp.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(txtNewOff.Text) - 1.0;
            temp = Math.Round(temp, 2);
            txtNewOff.Text = temp.ToString();
        }

        private void callbackround()
        {
            var previousform = Application.OpenForms.OfType<MarketSummer>().Single();
            previousform.RoundFinished();
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Negotiation Interrupted by you", "Failure");
            callbackround();
        }

        
    }
}

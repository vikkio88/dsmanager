using DsManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormDSSimulator
{
    public partial class MainForm : Form
    {
        #region GameObjects
        public static League l;

        //utility per ChampionsLeague
        public static League champ;
        public static bool doingchampL = false;
        //Champions League

        public static List<string> albo = new List<string>();
        public static List<string> alboplayer = new List<string>();
        public static List<string> boughtplayershistory = new List<string>();
        public static List<string> soldplayershistory = new List<string>();
        public static List<string> recordhistory = new List<string>();
        public static int[] vps = { 0, 0, 0 };
        public static int losecounter = 0;
        public static int drawcounter = 0;


        public static int matchrendered = 0;
        public static bool finished = false;
        //static Dictionary<Player, string> loaned = new Dictionary<Player, string>();



        public static int anno = 2014;
        public static string playername;
        public static double money = GameUtils.getRandomMoney();
        public static string playerteam;
        public static bool discorsetto = false;

        
        #endregion






        #region NewGameEvents
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            Program.toDefine();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            Program.toDefine();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pnlNewGame.Visible = true;
        }



        private void btnGenerateRandomTeams_Click(object sender, EventArgs e)
        {
           
           StreamMessageInStatus("Generating  Random Teams...");
           DisableGenerators();

           int numb = 0;
           if (cboNumb.SelectedIndex != -1)
           {
               numb = int.Parse(cboNumb.SelectedItem.ToString());
           }
           else
           {
               numb = int.Parse(cboNumb.Text);
           }

           
          
  
            
            
            l = new League(GameUtils.getRandomTeamsList(numb));
            l.generateFixture();

            StreamMessageInStatus("Completed");
            TeamListToListBox(l.leagueTeams, lstTeams);


             
        }



        private void ListSelectEvent(object sender, EventArgs e)
        {
            //showme(lstTeams.SelectedItem.ToString());
            txtTeamInfo.Text = l.getTeambyTeamName(lstTeams.SelectedItem.ToString()).ToStringFull();
        }

        private void btnGenerateTeamsFromFiles_Click(object sender, EventArgs e)
        {
            DisableGenerators();
           lblStatus.Text = "Reading configuration file...";
            List<string> teamNameList = ReadTeamNameFromFile();
            List<Team> teamList = new List<Team>();
            StreamMessageInStatus("done!\n\nReading Teams...");
            foreach (string team in teamNameList)
            {
                Console.WriteLine("Reading " + team + " ...");

                Team temp = new Team(UppercaseFirst(team));
                Console.Write("Reading " + team + " players from file...");
                temp.addPlayers(GameUtils.generatePlayersFromFile(team + ".txt"));
                Console.WriteLine("done!\nSetting a Random Coach...");
                temp.setCoach(GameUtils.getRandomCoachList().ElementAt(0));
                Console.WriteLine("team " + team + " completed...");
                teamList.Add(temp);
                GameUtils.wait();
            }
            l = new League(teamList);
            l.generateFixture();
            Console.WriteLine("done!");
            StreamMessageInStatus("Completed");
            TeamListToListBox(l.leagueTeams, lstTeams);
        }

        private void btnChooseTeam_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == string.Empty)
            {
                MessageBox.Show("Must insert your Name");
                return;
            }
            else
            {
                playername = txtPlayerName.Text;
                playerteam = lstTeams.SelectedItem.ToString();
                l.getTeambyTeamName(playerteam).isplayers = true;
                MessageBox.Show("Your Team budget for this years is " + money + " M €");
                pnlMainMenuGame.Visible = true;
            }

        }
#endregion

      #region MatchPlayerUtils
        private static void checkPlayerTeamResult(List<Match> list, bool showthem = false)
        {
            foreach (Match item in list)
            {
                if (item.AwayTeam.isplayers || item.HomeTeam.isplayers)
                {
                    if (playerteam == item.HomeTeam.TeamName)
                    {
                        if (!item.Draw())
                        {
                            if (item.Loser().TeamName == playerteam)
                            {
                                vps[2] += 1;
                                losecounter += 1;
                            }
                            else
                            {
                                vps[0] += 1;
                                losecounter = 0;
                                drawcounter = 0;
                            }
                        }
                        else //Pareggio
                        {
                            vps[1] += 1;
                            drawcounter += 1;
                            losecounter = 0;
                        }

                    }
                    else // la squadra del giocatore gioca fuori casa (nel caso volessi contare dentro e fuori casa)
                    {

                        if (!item.Draw())
                        {
                            if (item.Loser().TeamName == playerteam)
                            {
                                vps[2] += 1;
                                losecounter += 1;
                            }
                            else
                            {
                                vps[0] += 1;
                                losecounter = 0;
                                drawcounter = 0;
                            }
                        }
                        else //Pareggio
                        {
                            vps[1] += 1;
                            losecounter = 0;
                            drawcounter += 1;
                        }


                    }
                }
            }

        }

        #endregion  


        #region InitializationsUtils

        private static List<string> ReadTeamNameFromFile()
        {
            System.IO.StreamReader file = null;
            try
            {
                file = new System.IO.StreamReader("teams.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("impossible to find teams.txt\n Exiting...");
                Environment.Exit(1);
            }

            List<string> list = new List<string>();
            string line;

            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
            }

            return list;

        }

        #endregion

        #region DebugUtilsFunction

        private void showme(object ob)
        {
            MessageBox.Show(ob.ToString());
        }

        private void DisableGenerators()
        {
            btnGenerateTeamsFromFiles.Enabled = false;
            btnGenerateRandomTeams.Enabled = false;
            cboNumb.Enabled = false;
            btnChooseTeam.Enabled = true;
        }

        private void StreamMessageInStatus(string message)
        {
            lblStatus.Text = message;
            if (message == "Completed")
            {
                cleanStatus(2000);
            }
        }

        private void cleanStatus(int interval)
        {
            timerUtils.Interval = interval;
            timerUtils.Start();
        }

        private void EraseStatus()
        {
            lblStatus.Text = "";
            timerUtils.Stop();
        }
        #endregion

        #region TextUtilsFunction
        private static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        #endregion

        #region AdapterFunctions
        private void TeamListToListBox(List<Team> tl, ListBox lb)
        {

            List<string> teamnames = new List<string>();
            foreach (Team t in tl)
            {
                teamnames.Add(t.TeamName);
            }

            lb.DataSource = teamnames;
        }
        #endregion

        private void timerUtils_Tick(object sender, EventArgs e)
        {
            EraseStatus();
        }

        #region PnlMainMenuGame
        private void pnlMainMenuGame_Paint(object sender, PaintEventArgs e)
        {
            FillTeamInfo();
            FillNextRound();
            FillTableText();
            FillLastMatch();
        }

        private void FillLastMatch()
        {
            if (l.CurrentRound > matchrendered)
            {
                txtLastMatch.Text = l.getLastMatchbyTeamName(playerteam);
                matchrendered = l.CurrentRound;
            }
        }

        private void FillTableText()
        {
           
            txtTable.Text = l.getTableString(true);
        }

        private void FillTeamInfo()
        {
            txtPlayerTeamInfo.Text = "";
            txtPlayerTeamInfo.Text += "Season " + (anno - 1) + "/" + anno
                                        + "\r\n\t " + playername + " ds of: " + playerteam
            + "\r\n\t balance: " + money + " M Euro"
            + "\r\n\t Team position: " + l.getPositionbyTeamName(playerteam) + " / " + l.NumbOfTeam
            + string.Format("\r\n\t W: {0} D: {1} L: {2}", vps[0], vps[1], vps[2]);
            if (losecounter > 1) txtPlayerTeamInfo.Text += "\r\n\t consecutive lost matches: " + losecounter;
            txtPlayerTeamInfo.Text += "\r\n\t Round: " + l.CurrentRound + " / " + (l.NumbOfTeam - 1);
        }

        private void FillNextRound()
        {
            txtNextRound.Text = l.getStringFixtureAt(l.CurrentRound);
        }
        #endregion

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            StreamMessageInStatus("Playing round " + (l.CurrentRound + 1));

            l.simulateRound();
            checkPlayerTeamResult(l.getFixtureAt(l.CurrentRound-1));

            MessageBox.Show(l.getStringFixtureAt(l.CurrentRound - 1),"Results");



            if (l.CurrentRound == (l.NumbOfTeam - 1))
            {
                SeasonOver();
            }

            StreamMessageInStatus("Completed");

        }

        private void SeasonOver()
        {
            finished = true;
            btnNextRound.Enabled = false;
            playerReport();
        }

        private void playerReport()
        {
            int pos = l.getPositionbyTeamName(playerteam);
            if (pos == 1)
            {
                double price = GameUtils.getWage(5, 15);
                MessageBox.Show("Your Team won the League this year!\nthe price is " + price + " M Euro");

  
                money += price;
                alboplayer.Add(anno + " league champion - W: " + vps[0] + " D: " + vps[1] + " L: " + vps[2] + " coach: " + l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam)).coach.ToStringShort());
            }
            else if (pos == l.NumbOfTeam)
            {
                //doingchampL = false;
                MessageBox.Show("Your Team was last this year...");
                alboplayer.Add(anno + " " + l.NumbOfTeam + " position - W: " + vps[0] + " D: " + vps[1] + " L: " + vps[2] + " - coach: " + l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam)).coach.ToStringShort());
            }
            else
            {
               // doingchampL = false;
                MessageBox.Show("Your Team arrived " + pos + " / " + l.NumbOfTeam);
                alboplayer.Add(anno + " " + pos + " position - W: " + vps[0] + " D: " + vps[1] + " L: " + vps[2] + " coach: " + l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam)).coach.ToStringShort());
            }
        }

        private void btnFixture_Click(object sender, EventArgs e)
        {
            //Program.toDefine();
            FixtureForm fxt = new FixtureForm();

            fxt.Show();
        }








    }
}

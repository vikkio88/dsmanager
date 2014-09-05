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

            TeamListToListBox(l.leagueTeams, lstTeams);


             
        }



        private void ListSelectEvent(object sender, EventArgs e)
        {
            //showme(lstTeams.SelectedItem.ToString());
            txtTeamInfo.Text = l.getTeambyTeamName(lstTeams.SelectedItem.ToString()).ToStringFull();
        }

        private void btnGenerateTeamsFromFiles_Click(object sender, EventArgs e)
        {
            Console.Write("Reading configuration file...");
            List<string> teamNameList = ReadTeamNameFromFile();
            List<Team> teamList = new List<Team>();
            Console.WriteLine("done!\n\nReading Teams...");
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


    }
}

using DsManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDSSimulator
{
    static class Program
    {

        static League l;

        //utility per ChampionsLeague
        static League champ;
        static bool doingchampL = false;
        //Champions League

        static List<string> albo = new List<string>();
        static List<string> alboplayer = new List<string>();
        static List<string> boughtplayershistory = new List<string>();
        static List<string> soldplayershistory = new List<string>();
        static List<string> recordhistory = new List<string>();
        static int[] vps = { 0, 0, 0 };
        static int losecounter = 0;
        static int drawcounter = 0;
        //static Dictionary<Player, string> loaned = new Dictionary<Player, string>();



        static int anno = 2014;
        static string playername;
        static double money = GameUtils.getRandomMoney();
        static string playerteam;
        

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void toDefine()
        {
            MessageBox.Show("Feature not included yet!");
        }
    }
}

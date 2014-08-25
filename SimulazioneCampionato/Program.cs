using DsManager.Models;
using SimulazioneCampionato.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulazioneCampionato
{
    
    class Program
    {
        static League l;
        static List<string> albo = new List<string>();
        static List<string> alboplayer = new List<string>();

        static int anno = 2014;
        static string playername;
        static double money = GameUtils.getRandomMoney();
        static string playerteam;
       // static Team playerteam;
        static void Main(string[] args)
        {
            inizializePlayer();
            string A = "1";
            Console.WriteLine("Generate a random League(1) or Use a File(2)?[1/2]");
            A = Console.ReadLine();
            if (A == "1")
            {
                Console.WriteLine("How many Teams do you want in your League?");
                int a;
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a > 18)
                    {
                        throw new Exception("Too Many Teams");
                    }

                    if (a % 2 != 0)
                    {
                        //throw new Exception("Must be a pair number of Teams");
                        a -= 1;
                    }

                    if (a <= 0)
                    {
                        throw new Exception("Not enough teams");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message + "\n team number choose by default 8");
                        a=8;
                }

                Console.WriteLine("Hit enter to generate a random League");
                Console.ReadKey();
                Console.Write("generating...");
                l = new League(GameUtils.getRandomTeamsList(a));
                Console.WriteLine("done!");
            }
            else
            {
                Console.Write("Reading configuration file...");
                List<string> teamNameList = ReadTeamNameFromFile();
                List<Team> teamList = new List<Team>();
                Console.WriteLine("done!\n\nReading Teams...");
                foreach (string team in teamNameList)
                {
                    Console.WriteLine("Reading "+team+" ...");

                    Team temp = new Team(UppercaseFirst(team));
                    Console.Write("Reading " + team + " players from file...");
                    temp.addPlayers(GameUtils.generatePlayersFromFile(team+".txt"));
                    Console.WriteLine("done!\nSetting a Random Coach...");
                    temp.setCoach(GameUtils.getRandomCoachList().ElementAt(0));
                    Console.WriteLine("team "+ team+" completed...");
                    teamList.Add(temp);
                    GameUtils.wait();
                }
                l = new League(teamList);
                l.generateFixture();
                Console.WriteLine("done!");
            }

            Console.WriteLine("Enter to start...");
            Console.ReadLine();
            Console.Clear();

            chooseTeam();

            foreach (Team item in l.leagueTeams)
            {
                if (item.isplayers) playerteam = item.TeamName;
            }

            string cmd = "";
            while (cmd != "q")
            {
                command(ref cmd);
            }

        }

        private static void chooseTeam()
        {
            Console.WriteLine("So, "+playername+", now choose the Team you want to be DS of:");
            int c = 1;
            foreach (Team t in l.table.Keys)
            {
                Console.WriteLine(c+". "+t.TeamName);
                c++;
            }
            Console.Write("[1/"+(c-1)+"]> ");
            c = int.Parse(Console.ReadLine());
            showTeam(c);
        }

        private static void showTeam(int c)
        {
            try
            {
                
                if (c > l.NumbOfTeam)
                {
                    throw new InvalidOperationException();
                }
            }
            catch
            {
                c = 1;
            }
            Console.Clear();
            Team a = l.getTeamByTablePosition(c);
            Console.WriteLine(a.ToStringFull());
            Console.Write("\tDo you want to choose this one? [y/n]> ");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                l.getTeamByTablePosition(c).isplayers = true;
                Console.WriteLine("\t" + l.getTeamByTablePosition(c).TeamName+" choosen, your budget is "+ money + " M euros");
                EnterToContinue();
               // Console.Clear();
            }
            else
            {
                Console.Clear();
                chooseTeam();
            }
        }

        private static void inizializePlayer()
        {
            Console.WriteLine("**************************\n*     DS Simulator 2014   *\n**************************\n");
            Console.WriteLine("\n\nHello, welcome to DS Simulator 2014, insert your name to start this adventure: ");
            playername = Console.ReadLine();
        }

        private static List<string> ReadTeamNameFromFile()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("teams.txt");
            List<string> list = new List<string>();
            string line;
            
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
            }

            return list;

        }

        private static void command(ref string cmd)
        {
            printMenu();
            cmd = Console.ReadLine();
            execCmd(cmd);
        }

        private static void execCmd(string cmd)
        {
            if (cmd == "1")
            {
                Console.Clear();
                Console.WriteLine(l.getTableString());
            }
            else if (cmd == "2")
            {
                Console.Clear();
                
                try
                {

                    l.simulateRound();
                    Console.Write("simulating round " + ((l.CurrentRound)) + " ...");
                    GameUtils.wait(50);
                    Console.WriteLine("done");
                    l.printFixtureAt(l.CurrentRound - 1);
                }
                catch(Exception e)
                {
                    Console.WriteLine("No more match to play! League Ended");
                    Console.WriteLine(anno+" League Winner: "+l.getTeamByTablePosition(1).TeamName);
                    Console.WriteLine("Scorers table winner: "+ l.getStringScorerByScorerPosition(1));
                    
                    playerReport();
                    
                    askforcontinue();
                }
                
                
                GameUtils.wait();
                
            }
            else if(cmd=="3")
            {
                Console.Clear();
                Console.WriteLine(l.getTableString()+"\nSelect Team by Position");
                int n;
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n > l.NumbOfTeam)
                    {
                        throw new InvalidOperationException();
                    }
                }
                catch
                {
                    n = 1;
                }
                Console.Clear();
                Team a = l.getTeamByTablePosition(n);
                Console.WriteLine(a.ToStringFull());
            }
            else if (cmd == "4")
            {
                Console.Clear();
                if (l.CurrentRound > 0)
                {
                    Console.WriteLine(l.getScorerTable());
                }

            }
            else if (cmd == "5")
            {
                Console.Clear();
                Console.WriteLine("Select Round[1/"+(l.NumbOfTeam-1)+"]");
                int n;
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n > l.NumbOfTeam)
                    {
                        throw new InvalidOperationException();
                    }
                }
                catch
                {
                    n = 1;
                }
                Console.Clear();
                l.printFixtureAt(n-1);
            }
            else if (cmd == "")
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
        }

        private static void playerReport()
        {
            int pos = l.getPositionbyTeamName(playerteam);
            if (pos == 1)
            {
                double price = GameUtils.getWage(5, 15);
                Console.WriteLine("Your Team won the League this year!\nthe price is "+price+" M Euro");
                money += price;
                alboplayer.Add(anno + " league champion");
            }
            else if (pos == l.NumbOfTeam) 
            {
                Console.WriteLine("Your Team was last this year...");
                alboplayer.Add(anno + " "+l.NumbOfTeam+" position");
            }
            else
            {
                Console.WriteLine("Your Team arrived " + pos + " / "+l.NumbOfTeam);
                alboplayer.Add(anno + " " + pos + " position");
            }
        }

        private static void askforcontinue()
        {
            Console.WriteLine("Do you want to start another League? [y/n]");
            string yn = "";
            yn = Console.ReadLine();

            if (yn == "y") 
            {
                
                saveHistory();
                GameUtils.AgePlayers(l);
                EnterToContinue();
                GameUtils.CheckCoachWork(l);

                //LICENZIA ALLENATORE GIOCATORE
                FireCoach();

                EnterToContinue();
                l.reset();
                GameUtils.CalciomercatoRandom(l);
                EnterToContinue();
                //CALCIOMERCATO GIOCATORE
                MarketPlace();

                Console.WriteLine("\n\nhit enter to start a new Season");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                saveHistory();
                printAlbo();
                printAlboPlayer();
                Environment.Exit(0);
            }

        }

        private static void printAlboPlayer()
        {
            Console.WriteLine("Albo d'Oro della tua Squadra\n");
            foreach (string entry in alboplayer)
            {
                Console.WriteLine(entry);
            }
            Console.ReadLine();
        }

        private static void MarketPlace()
        {
           // throw new NotImplementedException();
            MarketPlaceSimulator mrk = new MarketPlaceSimulator(l, money);
            mrk.init();
            money = mrk.callbackMoney();
        }

        private static void FireCoach()
        {
           // throw new NotImplementedException();
            Team playersteam = new Team("bla");
            foreach (Team t in l.leagueTeams)
            {
                if (t.isplayers) playersteam = t;
            }

            if (l.getTeamByTablePosition(l.NumbOfTeam).TeamName != playersteam.TeamName)
            {
                double off =GameUtils.getWage(1,3);
                Console.WriteLine("Your Coach, " + playersteam.coach.ToStringShort() + " want a raise of "+off);
                Console.Write("\t do you want give it to him or you want to search for another coach? [y/n]> ");

                string s = Console.ReadLine();
                if (s == "y")
                {
                    Console.WriteLine("\t you paid "+off+" M Euro, to keep your Coach");
                    money -= off;
                }
                else
                {
                    Coach c = GameUtils.getRandomCoach();
                    Console.WriteLine("The president choose to hire \n"+ c.ToString()+"\n as new coach");
                    playersteam.setCoach(c);
                }
            }
            else
            {
                Console.WriteLine("You finished last this year, want to fire your coach " + playersteam.coach.ToStringShort() + "? ");
                Console.Write("\t[y/n]> ");

                string s = Console.ReadLine();
                if (s == "y")
                {
                    Coach c = GameUtils.getRandomCoach();
                    Console.WriteLine("The president choose to hire \n" + c.ToString() + "\n as new coach");
                    playersteam.setCoach(c);
                }
                else
                {
                    Console.WriteLine("\t you must love your Coach...");

                }
            }


        }

        private static void EnterToContinue()
        {
            Console.Write("hit enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        private static void printAlbo()
        {
            Console.WriteLine("Albo d'Oro del tuo Campionato\n");
            foreach (string entry in albo)
            {
                Console.WriteLine(entry);
            }
            Console.ReadLine();
        }

        private static void saveHistory()
        {
            albo.Add(anno + " " + l.getTeamByTablePosition(1).TeamName + "\n\tVincitore Marcatori: " + l.getStringScorerByScorerPosition(1));
            anno += 1;
        }

        private static void printMenu()
        {
            Console.WriteLine("****************\n      Main Menu\n****************");
            Console.WriteLine("\t "+playername+" ds of: "+playerteam);
            Console.WriteLine("\t balance: "+money+" M Euro");
            Console.WriteLine("\t Team position: "+l.getPositionbyTeamName(playerteam)+" / "+l.NumbOfTeam);
            Console.WriteLine("\t Round: "+l.CurrentRound+" / "+l.NumbOfTeam);
            Console.WriteLine(" 1. Print Table\n 2. Simulate Round\n 3. Get Info About Team\n 4. Print Scorers\n 5. Print Fixture at Round x\n\n\t q to quit");
        }

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
    }
}

using DsManager.Models;
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
        static int anno = 2014;
        static void Main(string[] args)
        {
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

            string cmd = "";
            while (cmd != "q")
            {
                command(ref cmd);
            }

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
                EnterToContinue();
                l.reset();
                GameUtils.CalciomercatoRandom(l);
                Console.WriteLine("\n\nhit enter to start a new Season");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                saveHistory();
                printAlbo();
                Environment.Exit(0);
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

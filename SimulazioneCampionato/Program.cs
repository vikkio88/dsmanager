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
        static void Main(string[] args)
        {
            string A = "1";
            Console.WriteLine("Generate a random League(1) or Use a File(2)?[1/2]");
            A = Console.ReadLine();
            if (A == "1")
            { 
                Console.WriteLine("Hit enter to generate a random League");
                Console.ReadKey();
                Console.Write("generating...");
                l = new League(GameUtils.getRandomTeamsList(10));
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
                Console.Write("simulating round "+((l.CurrentRound)+1)+" ...");
                l.simulateRound();
                Console.WriteLine("done");
                GameUtils.wait();
                l.printFixtureAt(l.CurrentRound - 1);
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
            else if (cmd == "")
            {
                Console.Clear();
            }
        }

        private static void printMenu()
        {
            Console.WriteLine("****************\n      Main Menu\n****************");
            Console.WriteLine(" 1. Print Table\n 2. Simulate Round\n 3. Get Info About Team\n 4. Print Scorers\n\n\t q to quit");
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

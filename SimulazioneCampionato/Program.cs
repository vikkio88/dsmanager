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
            
            Console.WriteLine("Hit enter to generate the League");
            Console.ReadKey();
            Console.Write("generating...");
            l = new League(GameUtils.getRandomTeamsList(10));
            Console.WriteLine("done!");
            string cmd = "";
            while (cmd != "q")
            {
                command(ref cmd);
            }

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
            else if (cmd == "")
            {
                Console.Clear();
            }
        }

        private static void printMenu()
        {
            Console.WriteLine("1. Print Table\n2. Simulate Round\n3. Get Info About Team\n\n\t q to quit");
        }
    }
}

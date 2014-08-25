﻿using DsManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulazioneCampionato.Utils
{
    class MarketPlaceSimulator
    {
        League l;
        Team plt;
        List<Team> otherst;
        List<string> history;
        double money;
        int currentround = 1;
        int rounds = 15;
        
        public MarketPlaceSimulator(League le, double m)
        {
            this.l = le;
            this.money = m;
            this.otherst = new List<Team>();
            this.history = new List<string>();
            foreach (Team t in this.l.leagueTeams)
            {
                if (t.isplayers)
                {
                    this.plt = t;
                }
                else
                {
                    otherst.Add(t);
                }

            }
        }
        public double callbackMoney()
        {
            return Math.Round(this.money,2);
        }


        public void init()
        {
         
            string cmd = "";
            while (cmd != "q" && currentround <= rounds)
            {
                command(ref cmd);
                currentround++;
            }

            Console.WriteLine("Market Ended!");

        }

        private void command(ref string cmd)
        {
            printMenu();
            cmd = Console.ReadLine();
            execCmd(cmd);
        }

        private void execCmd(string cmd)
        {
            if (cmd == "1")
            {
               Console.Clear();
               printTeams();
               Console.Write("Choose the team > ");
               Team cteam = chooseTeam();
               printPlayers(cteam);
               Console.Write("Choose the player > ");
               Player cpl = choosePlayer(cteam);
               trytobuy(cpl,cteam);

               RandomOffer();

            }
            else if(cmd =="2")
            {
                Player tmp = printandChooseRandomPlayers();
                trytobuy(tmp);

                RandomOffer();
            }
            else if(cmd == "3")
            {
                trainTeam();
                RandomOffer();
            }
        }

        private void trainTeam()
        {
            Random rnd = new Random();
            if (rnd.Next(100) > 50)
            {
                Console.WriteLine("Training successfull");
                Player pl = plt.getPlayer(rnd.Next(plt.NumbOfPlayers));
                int mod = rnd.Next(1,5);
                pl.SkillAvg += mod;
                Console.WriteLine("\t "+pl.ToStringShort()+" ++"+mod);
            }
            else
            {
                Console.WriteLine("Training was a disaster...");
            }
            EnterToContinue();
            
        }

        private void trytobuy(Player cpl)
        {
            Console.Clear();
            Console.WriteLine("Trying to buy " + cpl.ToString() + " from  FreePlayers List");
            double req = Math.Round((cpl.Val + (GameUtils.getWage(0, 5))), 2);
            Console.WriteLine("\t He asked: " + req + " M Euro\n your offer [money owned: " + money + " M euro] > ");
            double off = double.Parse(Console.ReadLine());
            if (off < money)
            {
                Console.WriteLine(off + "M euro ...offert sent..");
                GameUtils.wait(1000);
                Console.WriteLine("Offert received...");
                Console.Write("...I am thinking about it...");
                GameUtils.wait(1000);
                Random rnd = new Random();
                if (off >= req)
                {
                    if (rnd.Next(100) > 10)
                    {
                        Console.WriteLine("I accept your offer...");
                        //Player tmp = cteam.popPlayer(cpl);
                        plt.addPlayer(cpl);
                        Console.WriteLine("\t you hired " + cpl.ToString() + " ");
                        report("+ "+cpl.ToStringShort() + " - val: " + cpl.Val + " - off: " + off + " M euro, from FreeList");
                        money -= off;
                    }
                    else
                    {
                        Console.WriteLine("I refuse your offer...");
                    }
                }
                else
                {
                    if (rnd.Next(100) > 50)
                    {
                        Console.WriteLine("I accept your offer...");
                       // Player tmp = cteam.popPlayer(cpl);
                        plt.addPlayer(cpl);
                        Console.WriteLine("\t you hired " + cpl.ToString() + " ");
                        report("+ " + cpl.ToStringShort() + " - val: " + cpl.Val + " - off: " + off + " M euro, from FreeList");
                        money -= off;
                    }
                    else
                    {
                        Console.WriteLine("I refuse your offer...");
                    }
                }
            }
            else if (off <= 0)
            {
                Console.WriteLine("I kindly refuse your shitty offer");
            }
            else
            {
                Console.WriteLine("You dont have enough money...");
            }

            EnterToContinue();
        }

        private void report(string p)
        {
            history.Add(p);
        }

        private Player printandChooseRandomPlayers()
        {
            Console.Clear();
            Console.WriteLine("Free Players List");
            int c = 1;
            List<Player> collection = GameUtils.getRandomPlayersList(15);
            foreach (Player pl in collection)
            {
                Console.WriteLine(c+". "+pl.ToString());
                c++;
            }

            Console.Write("[1/15]> ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                return collection.ElementAt(n - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("wrong number,I choose the first...");
                int n = 1;
                return collection.ElementAt(n - 1);
            }
        }

        private void RandomOffer()
        {
            Console.Clear();
           // throw new NotImplementedException();
            Console.WriteLine("Incoming offer...");
            Random rnd = new Random();
            Team t = otherst.ElementAt(rnd.Next(otherst.Count));
            Player pl = plt.getPlayer(rnd.Next(plt.NumbOfPlayers));
            double off = Math.Round(pl.Val + GameUtils.getWage(0, 4));
            Console.WriteLine("\t "+t.TeamName+" offer "+off+" M euro for ");
            Console.WriteLine("\t"+pl.ToString());
            Console.Write("Do you accept? [y/n] > ");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Player tmp = plt.popPlayer(pl);
                t.addPlayer(tmp);
                money += off;
                Console.WriteLine("\t"+tmp.ToStringShort()+" sold to "+t.TeamName);
                report("- " + tmp.ToStringShort() + " - val: " + tmp.Val + " - off: " + off + " M euro, to " + t.TeamName);
            }
            else
            {
                Console.WriteLine("Offer refused...");
            }

            EnterToContinue();

        }

        private void trytobuy(Player cpl, Team cteam)
        {
            Console.Clear();
            Console.WriteLine("Trying to buy "+cpl.ToString()+" from "+ cteam.TeamName);
            double req = Math.Round((cpl.Val + (GameUtils.getWage(0, 5))), 2);
            Console.WriteLine("\t they asked: "+req+" M Euro\n your offer [money owned: "+money+" M euro] > ");
            double off = double.Parse(Console.ReadLine());
            if (off < money && off>0)
            {
                Console.WriteLine(off+"M euro ...offert sent..");
                GameUtils.wait(1000);
                Console.WriteLine("Offert received...");
                Console.Write("...We are thinking about it...");
                GameUtils.wait(1000);
                Random rnd = new Random();
                if (off - req > 10)
                {
                    Console.WriteLine("we accept your generous offer...");
                    Player tmp = cteam.popPlayer(cpl);
                    plt.addPlayer(tmp);
                    Console.WriteLine("\t you hired " + tmp.ToString() + " ");
                    report("+ " + cpl.ToStringShort() + " - val: " + cpl.Val + " - off: " + off + " M euro, from "+cteam.TeamName);
                    money -= off;
                }
                else if (off >= req)
                {
                    if (rnd.Next(100) > 20)
                    {
                        Console.WriteLine("we accept your offer...");
                        Player tmp = cteam.popPlayer(cpl);
                        plt.addPlayer(tmp);
                        Console.WriteLine("\t you hired "+tmp.ToString()+" ");
                        report("+ " + cpl.ToStringShort() + " - val: " + cpl.Val + " - off: " + off + " M euro, from " + cteam.TeamName);
                        money -= off;
                    }
                    else
                    {
                        Console.WriteLine("We refuse your offer...");
                    }
                }
                else
                {
                    if (rnd.Next(100) > 50)
                    {
                        Console.WriteLine("we accept your offer...");
                        Player tmp = cteam.popPlayer(cpl);
                        plt.addPlayer(tmp);
                        Console.WriteLine("\t you hired " + tmp.ToString() + " ");
                        report("+ " + cpl.ToStringShort() + " - val: " + cpl.Val + " - off: " + off + " M euro, from " + cteam.TeamName);
                        money -= off;
                    }
                    else
                    {
                        Console.WriteLine("We refuse your offer...");
                    }
                }
            }else if(off<=0){
                Console.WriteLine("We kindly refuse your shitty offer");
            }
            else
            {
                Console.WriteLine("You dont have enough money...");
            }
            EnterToContinue();
        }

        private Player choosePlayer(Team cteam)
        {
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n > otherst.Count)
                {
                    throw new Exception();
                }

                if (n < 1)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                n = 1;
            }

            return cteam.getPlayer(n - 1);
        }

        private void printPlayers(Team cteam)
        {
            int c = 1;
            foreach (Player pl in cteam.players)
            {
                Console.WriteLine(c+". "+pl.ToString());
                c++;
            }
        }

        private Team chooseTeam()
        {
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n > otherst.Count)
                {
                    throw new Exception();
                }

                if (n < 1)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                n = 1;
            }

            return otherst.ElementAt(n - 1);

        }

        private void printTeams()
        {
            int c = 1;
            foreach (Team t in otherst)
            {
                Console.WriteLine(c + ". " + t.TeamName);
                c++;
            }
        }

        private void printMenu()
        {
            Console.Clear();
            Console.WriteLine("\n********MarketPlace*****\n");
            Console.WriteLine("\t" + plt.TeamName + " balance: " + money + " M Euro");
            Console.WriteLine("day "+currentround+" / "+rounds);
            Console.WriteLine("\n 1. Search for Player in your League \n 2. View Free Player \n 3. Train your Team\n\t q to exit MarketPlace");
            Console.WriteLine(plt.ToStringFull());
           
   
                Console.WriteLine("***Your coach want to play with: "+plt.coach.FavouriteModule.ToString()+"\n you need those players: ");
                int[] n = plt.coach.FavouriteModule.playerForRolesForModule();
                string[] m = Module.getRoles().ToArray();
                int length = n.Count();
                for (int i = 0; i < length; i++)
                {
                    if (n[i] != 0)
                    {
                        Console.Write(m[i] + " " + n[i].ToString()+ "  ;  ");
                    }
                }
                Console.WriteLine();
            
        }

        private static void EnterToContinue()
        {
            Console.Write("hit enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public void printReport()
        {
            Console.WriteLine("Report Market");
            foreach (string item in history)
            {
                Console.WriteLine(item);
            }
        }

    }
}

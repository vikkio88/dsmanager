﻿using ConsoleUtils;
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

       // static Team playerteam;
        static void Main(string[] args)
        {
            inizializePlayer();
            int A = 1;
            Console.WriteLine("Generate a random League(1) or Use a File(2)?");
            A = MyConsole.AskForInt(2);
            if (A == 1)
            {
                Console.WriteLine("How many Teams do you want in your League? [4/18]");
                int a;
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a < 4)
                    {
                        throw new Exception("Too enough Teams");
                    }

                    if (a > 18)
                    {
                        throw new Exception("Too Many Teams");
                    }

                    if (a % 2 != 0)
                    {
                        //throw new Exception("Must be a pair number of Teams");
                        a += 1;
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
            quit();

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
           /* Console.Write("[1/"+(c-1)+"]> ");
            c = int.Parse(Console.ReadLine());*/
            c = MyConsole.AskForInt(l.NumbOfTeam);
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
            Console.Write("\n\nHello, welcome to DS Simulator 2014\n\tinsert your full name: ");
            playername = MyConsole.AskForFullName();
        }

        private static List<string> ReadTeamNameFromFile()
        {
            System.IO.StreamReader file = null ;
            try
            {
                file = new System.IO.StreamReader("teams.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("impossible to find teams.txt\n Exiting...");
                EnterToContinue();
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

        private static void command(ref string cmd)
        {
          
            printMenu();
            cmd = Console.ReadLine();
            execCmd(cmd);
        }

        private static void interview()
        {
            if (l.CurrentRound > 1)
            {
                if (GameUtils.getProbability(20))
                {
                    interviewQA();
                }
            }
        }

        private static void interviewQA()
        {
            bool buono = false;
            string jname = GameUtils.getRandomCoach().CoachName+" "+GameUtils.getRandomCoach().CoachSurname;
            Console.WriteLine("Interview\n");
            if (vps[0] > vps[2])
            {
                buono = true;
            }

            Console.WriteLine(jname + ": Hello, "+GameUtils.getRandomNewsPaperName()+" newspaper here, I would like to ask you some questions");
            Console.WriteLine("\t 1. Ok sure, go on\n\t 2. Nope, bye");
            int c = MyConsole.AskForInt(2);

            if (c == 1)
            {
                if (buono)
                {
                    Console.WriteLine(jname+": Ok thx, so... your team is going well, do you think they can do even better?");
                    if (MyConsole.AskForYorN(false,true))
                    {
                        if (GameUtils.getProbability(50))
                        {
                            l.getTeambyTeamName(playerteam).coach.SkillAvg += 1;
                            Console.WriteLine("\tYour Coach is motivated by your interview");
                        }
                        else
                        {
                            l.getTeambyTeamName(playerteam).coach.SkillAvg -= 1;
                            Console.WriteLine("\tYour Coach feels under pressure after your interview");
                        }
                    }
                    else
                    {
                        if (GameUtils.getProbability(50))
                        {
                            l.getTeambyTeamName(playerteam).coach.SkillAvg += 1;
                            Console.WriteLine("\tYour Coach is motivated by your interview");
                        }

                    }

                }
                else //Andamento negativo
                {

                    Console.WriteLine(jname + ": Ok thx, so... your team is going not so well, do you think they can do better?");
                    if (MyConsole.AskForYorN(false, true))
                    {
                        if (GameUtils.getProbability(50))
                        {
                            l.getTeambyTeamName(playerteam).coach.SkillAvg += 2;
                            Console.WriteLine("\tYour Coach is motivated by your interview");
                        }
                        else
                        {
                            l.getTeambyTeamName(playerteam).coach.SkillAvg -= 5;
                            Console.WriteLine("\tYour Coach feels under pressure after your interview");
                        }
                    }
                    else
                    {
                        if (GameUtils.getProbability(50))
                        {
                            l.getTeambyTeamName(playerteam).coach.SkillAvg -= 5;
                            Console.WriteLine("\tYour Coach feels under pressure after your interview");
                        }

                    }


                }

                Console.WriteLine(jname+": Thank you for this interview, goodbye");
            }
            else
            {
                Console.WriteLine(jname+": Well, thanks the same...");
            }

            EnterToContinue();
        }

        private static void execCmd(string cmd)
        {

            //  1. Simulate Round\n 2. Print Table\n 3. Print Scorers\n 4. Get Team Info \n 5. Get Info About Team\n 6. Print Fixture at Round x
            if (cmd == "2")
            {
                Console.Clear();
                Console.WriteLine("League Table");
                Console.WriteLine(l.getTableString(true));
            }
            else if (cmd == "1")
            {
                Console.Clear();
                
                try
                {
                    
                    l.simulateRound();
                    Console.Write("simulating round " + ((l.CurrentRound)) + " ...");
                    GameUtils.wait(50);
                    Console.WriteLine("done");
                    Console.WriteLine("\nResults\n");
                    l.printFixtureAt(l.CurrentRound - 1);
                    
                    //controllo risultato giocatore
                    checkPlayerTeamResult(l.getFixtureAt(l.CurrentRound - 1));//,true); Possibilita di stampare report risultato per squadra

                    checkCoachworksofar();
                    interview();

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
            else if(cmd=="5")
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
            else if (cmd == "3")
            {
                Console.Clear();
                if (l.CurrentRound > 0)
                {
                    Console.WriteLine(l.getScorerTable(25));
                }

            }
            else if (cmd == "6")
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
            else if (cmd == "4")
            {
                Console.Clear();
                Team a = l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam));
                Console.WriteLine("Team scorers");
                foreach (Player pl in a.players)
                {
                    int goals;
                    if (l.scorers.ContainsKey(pl))
                    {
                        goals = l.scorers[pl].goals;
                    }
                    else
                    {
                        goals = 0;
                    }
                    Console.WriteLine(pl.ToString()+" -goals: "+goals);
                }


            }
            else if (cmd == "7")
            {
                SpeakWithCoach(true);
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

        private static void checkPlayerTeamResult(List<Match> list,bool showthem = false)
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

        private static void playerReport()
        {
            int pos = l.getPositionbyTeamName(playerteam);
            if (pos == 1)
            {
                double price = GameUtils.getWage(5, 15);
                Console.WriteLine("Your Team won the League this year!\nthe price is "+price+" M Euro");

                Console.WriteLine("\n\tYou team is qualified the Champions League for the next Year\n");
                doingchampL = true;



                money += price;
                alboplayer.Add(anno + " league champion - W: " + vps[0] + " D: " + vps[1] + " L: " + vps[2] + " coach: " + l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam)).coach.ToStringShort());
            }
            else if (pos == l.NumbOfTeam) 
            {
                doingchampL = false;
                Console.WriteLine("Your Team was last this year...");
                alboplayer.Add(anno + " " + l.NumbOfTeam + " position - W: " + vps[0] + " D: " + vps[1] + " L: " + vps[2] + " - coach: " + l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam)).coach.ToStringShort());
            }
            else
            {
                doingchampL = false;
                Console.WriteLine("Your Team arrived " + pos + " / "+l.NumbOfTeam);
                alboplayer.Add(anno + " " + pos + " position - W: " + vps[0] + " D: " + vps[1] + " L: " + vps[2] + " coach: " + l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam)).coach.ToStringShort());
            }
        }

        private static void askforcontinue()
        {
            Console.WriteLine("Do you want to start another League? [y/n]");
            string yn = "";
            yn = Console.ReadLine();

            if (yn == "y") 
            {
                Console.Clear();
                Console.WriteLine(anno+"  -> "+(anno+1));
                
                
                losecounter = 0;
                drawcounter = 0;
                discorsetto = false;
                vps = new int[]{0,0,0};

                saveHistory();

                anno += 1;

                Console.WriteLine("Player retired this year");
                GameUtils.AgePlayers(l);
                EnterToContinue();

                //Console.WriteLine("Player returned after loan year");
                //returnFromLoan();
                //EnterToContinue();

                Console.WriteLine("Other teams's Coach valutation...");
                GameUtils.CheckCoachWork(l);
                Console.WriteLine("\n\n*****************\n\n");
                //LICENZIA ALLENATORE GIOCATORE
                FireCoach();

                EnterToContinue();
                l.reset();
                GameUtils.CalciomercatoRandom(l);
                EnterToContinue();
                //CALCIOMERCATO GIOCATORE
                MarketPlace();

                checkgoalkeeper();


                Console.WriteLine("\n\nhit enter to start a new Season");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                quit();
            }

        }

        //private static void returnFromLoan()
        //{
        //    foreach (KeyValuePair<Player, string> plonloan in loaned)
        //    {
        //        Team tmpT = l.getTeambyTeamName(plonloan.Value);
        //        l.getTeambyTeamName(playerteam).addPlayer(tmpT.popPlayer(plonloan.Key));
        //        Console.WriteLine("from " + plonloan.Value + ": " + plonloan.Key.ToString());
        //    }

        //    loaned = new Dictionary<Player, string>();
        //}

        private static void quit()
        {
            saveHistory();
            printAlbo();
            printAlboPlayer();
            printMarketRecords();
            printMarketHistory();
            Environment.Exit(0);
        }

        private static void printMarketRecords()
        {
            Console.Clear();
            Console.WriteLine("Market Records\n");
            foreach (string item in recordhistory)
            {
                Console.WriteLine("\n"+item);
            }
            Console.ReadLine();
        }

        private static void printMarketHistory()
        {
            Console.Clear();
            Console.WriteLine("Market History\n");
            Console.WriteLine("\n **Bought Player\n");
            foreach (string entry in boughtplayershistory)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("\n\n **Sold Player");
            foreach (string entry in soldplayershistory)
            {
                Console.WriteLine(entry);
            }

            Console.ReadLine();
        }

        private static void checkgoalkeeper()
        {
            Team a = l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam));
            try
            {
                a.getPlayerForRole("PT");
            }
            catch (Exception e)
            {
                Console.WriteLine("Your team doesnt have a goalKeeper\nproviding one from the free list");
                Player tmp = GameUtils.getRandomPlayersPerRole("PT").ElementAt(0);
                Console.WriteLine("hired: "+tmp.ToString());
                a.addPlayer(tmp);
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
           
            MarketPlaceSimulator mrk = new MarketPlaceSimulator(l, money);
            mrk.init();
            money = mrk.callbackMoney();
            addMarketHistory(mrk.callbackbought(), mrk.callbacksold());
            AddMarketRecord(mrk.callbackrecords());

           // loaned = mrk.callbackLoaned();
            mrk.printReport();

        }

        private static void AddMarketRecord(string[] record)
        {
            recordhistory.Add(anno + "\nbought: " + record[0] + "\nsold: " + record[1]);
        }

        private static void addMarketHistory(List<string> bought, List<string> sold)
        {
            boughtplayershistory.Add(anno.ToString());
           
            foreach (string item in bought)
            {
                boughtplayershistory.Add(item);
            }

            soldplayershistory.Add(anno.ToString());
            foreach (string item in sold)
            {
                soldplayershistory.Add(item);
            }
            
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
                Console.Write("\t do you want to? [y/n]> ");

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

            playersteam.coach.FavouriteModule = GameUtils.getRandomCoach().FavouriteModule;
            Console.WriteLine("\t"+playersteam.coach.ToStringShort() + " module for the next year: " + playersteam.coach.FavouriteModule);

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
            albo.Add(anno + " " + l.getTeamByTablePosition(1).TeamName + " p:"+l.getPointByPosition(1)+"\n\tVincitore Marcatori: " + l.getStringScorerByScorerPosition(1));
            
        }

        private static void printMenu()
        {
           // losecounter = 3;
            

            Console.WriteLine("****************\n      Main Menu\n****************");
            Console.WriteLine("Season "+(anno-1)+"/"+anno);
            Console.WriteLine("\t "+playername+" ds of: "+playerteam);
            Console.WriteLine("\t balance: "+money+" M Euro");
            Console.WriteLine("\t Team position: "+l.getPositionbyTeamName(playerteam)+" / "+l.NumbOfTeam);
            Console.WriteLine("\t W: {0} D: {1} L: {2}",vps[0],vps[1],vps[2]);
            if (losecounter > 1) Console.WriteLine("\t consecutive lost matches: "+losecounter);
            Console.WriteLine("\t Round: "+l.CurrentRound+" / "+(l.NumbOfTeam-1));
            
            if (l.CurrentRound != (l.NumbOfTeam - 1))
            {
                Console.WriteLine(" 1. Simulate Round\n 2. Print Table\n 3. Print Scorers\n 4. Get Team Scorer \n 5. Get Info About Team\n 6. Print Fixture at Round x\n 7. Speak with your Coach\n\n\t q to quit");
            }
            else
            {
                Console.WriteLine(" 1. Season Report\n 2. Print Table\n 3. Print Scorers\n 4. Get Team Scorer \n 5. Get Info About Team\n 6. Print Fixture at Round x\n 7. Speak with your Coach\n\n\t q to quit");
            }

      
        }

        private static void checkCoachworksofar()
        {
            if (losecounter > 4 && discorsetto)
            {
                discorsetto = false;
            }

            if (drawcounter > 3)
            {
                Console.WriteLine("\n\tAnother draw, really?");
                Console.WriteLine("\t Your coach is drawing a lot, speak with him");
                EnterToContinue();
                SpeakWithCoach(true);
            }

            if (losecounter > 2 && !discorsetto)
            {
                Console.WriteLine("\n\tAnother lost match, really?");
                Console.WriteLine("\t Your coach lost more than 3 matches in a row, speak with him");
                EnterToContinue();
                SpeakWithCoach();

            }
        }

        private static void SpeakWithCoach(bool draw=false)
        {
           // throw new NotImplementedException();
            Team t = l.getTeamByTablePosition(l.getPositionbyTeamName(playerteam));
            string coachN = t.coach.CoachName;
            Console.WriteLine(coachN+": Hello, mr "+playername+", did you want to see me?");
            Console.WriteLine("\t 1. Ask him more\n\t 2. Fire Him!");
            int c = MyConsole.AskForInt(2);
            int prob,prob1;
            if (l.getPositionbyTeamName(playername) > l.NumbOfTeam / 2)
            {
                prob1 = 80;
            }
            else
            {
               prob1 = 50;
            }
             prob = Convert.ToInt32(GameUtils.getWage(0,100));
            if (c == 1)
            {
                if (prob > prob1)
                {
                    t.coach.SkillAvg += 1;
                    if (t.coach.SkillAvg > 100) t.coach.SkillAvg = 100;
                    Console.WriteLine(coachN+": I will improve, promise!");
                    GameUtils.wait();
                    if (GameUtils.getWage(0, 100) > 20)
                    {
                        Console.WriteLine(coachN+": I think we need to change module");
                        GameUtils.wait(1000);
                        Console.WriteLine(coachN+": ...Let me think...");
                        GameUtils.wait(2000);
                        t.coach.FavouriteModule = GameUtils.getRandomCoach().FavouriteModule;
                        Console.WriteLine(coachN+": The module now will be: "+t.coach.FavouriteModuleString);
                        Console.WriteLine(coachN+": We will see now...");
                    }
                    discorsetto = true;
                }
                else
                {
                    t.coach.SkillAvg -= 5;
                    Console.WriteLine(coachN + ": Dont Talk with me like that! I am a professional Coach!");
                    Console.WriteLine(coachN + ": I know what I am doing!");
                    discorsetto = true;
                }
            }
            else if (c == 2)
            {
                FireCoachW(t);
            }

            if (draw)
            {
                discorsetto = false;
            }
            EnterToContinue();
            execCmd("");
    
        }

        private static void FireCoachW(Team plt)
        {
            //throw new NotImplementedException();
            losecounter = 0;
            drawcounter = 0;
            Coach c = GameUtils.getRandomCoach();
            Console.WriteLine("You fired your Coach\nThe president choose to hire \n" + c.ToString() + "\n as new coach");
            plt.setCoach(c);
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

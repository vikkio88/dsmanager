using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public static class GameUtils
    {

        public static double getRandomMoney()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            double ret = rnd.getInt(3, 80);
            return Math.Round(ret, 2);
        }
        public static List<Player> getRandomPlayersPerRole(string role,int n = 1)
        {
            List<Player> list = new List<Player>();
            if (Module.getRoles().IndexOf(role) < 0)
            {
                throw new InvalidOperationException("Ruolo non esistente");
            }

            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Player(rnd.getName(), rnd.getSurname(), rnd.getAge(), rnd.getAvgSkill(), role));
                wait();
            }

            return list;
        }
        public static List<Player> getRandomPlayersList(int n=1)
        {
            List<Player> list = new List<Player>();
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Player(rnd.getName(), rnd.getSurname(),rnd.getAge(),rnd.getAvgSkill(),rnd.getRole()));
                System.Threading.Thread.Sleep(5);
            }

            return list;
        }
        public static List<Coach> getRandomCoachList(int n = 1)
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            List<Coach> list = new List<Coach>();
            for (int i = 0; i < n; i++)
            {
                Coach rndCoach = new Coach(rnd.getName(), rnd.getSurname(), rnd.getAvgSkill(), rnd.getModules());
                list.Add(rndCoach);
                wait();
            }
           
            return list;
        }

        public static Coach getRandomCoach()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            return new Coach(rnd.getName(), rnd.getSurname(), rnd.getAvgSkill(), rnd.getModules());
        }

        public static List<Player> getRandomPlayersForModule(Module m)
        {
            List<Player> list = new List<Player>();

            string[] roles = Module.getRoles().ToArray();

            int[] plfr = m.playerForRolesForModule();
            int length = plfr.Count();

            for (int i = 0; i < length; i++)
            {
                if (plfr[i] > 0)
                {
                    List<Player> temp = getRandomPlayersPerRole(roles[i], plfr[i]);
                    foreach (Player item in temp)
                    {
                        list.Add(item);
                    }
                }
                wait(13);
            }


            return list;
        }

        public static List<Team> getRandomTeamsList(int n=1){
            List<Team> list = new List<Team>();
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            for (int i = 0; i < n; i++)
            {
                Team tempTeam = new Team(rnd.getTeamName());
                tempTeam.addPlayers(getRandomPlayersList(15));
                tempTeam.setCoach(getRandomCoachList().First());
                list.Add(tempTeam);
                wait();
            }

            return list;
        }

        public static List<Player> generatePlayersFromFile(string Path="players.txt")
        {
            System.IO.StreamReader file = new System.IO.StreamReader(Path);
            List<Player> list = new List<Player>();
            string line;
            int counter=0;
            while ((line = file.ReadLine()) != null)
            {
                Player p = new Player(line);
                list.Add(p);
                counter++;
            }

            file.Close();

            return list;
        }

        public static Player getScorer(Team a)
        {
            List<Player> list = a.getPlayers();
            Shuffle<Player>(list);
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            List<Player> scorers = new List<Player>();
            for (int i = 0; i < a.NumbOfPlayers-4; i++)
            {
                Player scorer = list.ElementAt(rnd.getInt(a.NumbOfPlayers));
                while (scorer.Role=="PT")
                {
                    scorer = list.ElementAt(rnd.getInt(a.NumbOfPlayers));
                }
                scorers.Add(scorer);
                
            }

            foreach (Player item in scorers)
            {
                if (item.Role == "AC") return item;
                if (item.Role == "AS") return item;
                if (item.Role == "AD") return item;
            }

            return scorers.First();



        }

        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void wait(int millisec= 5)
        {
            System.Threading.Thread.Sleep(millisec);
        }

        public static void AgePlayers(League l)
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            foreach (Team t in l.leagueTeams)
            {
                List<Player> toremove = new List<Player>();
                foreach (Player pl in t.players)
                {
                    pl.Age += 1;

                    if (pl.Age > 34)
                    {
                        if (rnd.getInt(100) > 50)
                        {
                            toremove.Add(pl);
                        }
                    }
                    else
                    {
                        if (pl.Age > 31)
                        {
                            pl.SkillAvg -= rnd.getInt(0, 3);
                        }
                        else
                        {
                            pl.SkillAvg += rnd.getInt(0, 3);
                            if (pl.Age < 19) pl.SkillAvg += rnd.getInt(1, 3);
                        }
                    }
                }

                //rimuovi giocatori
                foreach (Player torm in toremove)
                {
                    Console.WriteLine(torm.ToStringShort()+" from team "+t.TeamName+" retired");
                    t.rmPlayer(torm);
                }
                
            }
        }



        public static void CalciomercatoRandom(League l)
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            List<Team> tlist = l.leagueTeams;
            List<Player> onmarket = new List<Player>();
            Console.WriteLine("Finestra di Calciomercato\n\n");
            //put some random player on a list
            foreach (Team t in tlist)
            {
                if (t.isplayers) continue;
                int howmany = rnd.getInt(0,3);
                for (int i = 0; i < howmany ; i++)
                {
                    Player temp = t.popPlayerAt(rnd.getInt(t.NumbOfPlayers));
                    Console.WriteLine(t.TeamName+" put "+temp.ToStringShort()+" on the transfer list");
                    onmarket.Add(temp);
                }
            }
            Console.WriteLine("\n******************\n");
            //assign those players to a new team randomly
            foreach (Player pl in onmarket)
            {
                int n = rnd.getInt(1, l.NumbOfTeam);
                Team temp = l.getTeamByTablePosition(n);
                while(temp.isplayers){
                    n = rnd.getInt(1, l.NumbOfTeam);
                    temp = l.getTeamByTablePosition(n);
                    wait();
                }
                Console.WriteLine(temp.TeamName+" bought "+pl.ToStringShort());
                temp.addPlayer(pl);
            }

            //Balancing Team with Random Players
           /* int tot = 0;
            foreach (Team t in tlist)
            {
                tot += t.NumbOfPlayers;
            }
            int avg = tot / l.NumbOfTeam;
            */
            //balancing on 15 players per team
            int avg = 13;

            Console.WriteLine("\n******************\n");
            foreach (Team t in tlist)
            {
                //Give a Random Goalkeeper if team does not have one
                try
                {
                    t.getPlayerForRole("PT");
                }
                catch (Exception e)
                {
                    //if there is not a PT
                    Console.WriteLine(t.TeamName + " got new goalkeeper");
                    Player tmp = GameUtils.getRandomPlayersPerRole("PT").ElementAt(0);
                    t.addPlayer(tmp);
                    Console.WriteLine("\t" + tmp.ToStringShort());

                    wait();
                }
                //

                int missingpl = avg - t.NumbOfPlayers;
                if (missingpl > 0)
                {
                    List<Player> rndpl = new List<Player>();
                    Console.WriteLine(t.TeamName+" got new players");
                     rndpl = getRandomPlayersList(missingpl);
                    foreach (Player pl in rndpl)
                    {
                        Console.WriteLine("\t"+pl.ToStringShort());
                        t.addPlayer(pl);
                    }
                    wait(7);
                }
            }
        }

        public static void CheckCoachWork(League l)
        {
            Team last = l.getTeamByTablePosition(l.NumbOfTeam);
            Team secondLast = l.getTeamByTablePosition(l.NumbOfTeam-1);
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
           
            //if is not a player team
            if (last.isplayers == false)
            {
                if (rnd.getInt(100) > 20)
                {
                    Console.WriteLine(last.TeamName + " fired the coach " + last.getCoach().ToStringShort());
                    Coach temp = getRandomCoach();
                    last.setCoach(temp);
                    Console.WriteLine("\tThey hired " + temp.ToStringShort());
                }
            }

            wait();

            if (secondLast.isplayers == false)
            {
                if (rnd.getInt(100) > 60)
                {
                    Console.WriteLine(secondLast.TeamName + " fired the coach " + secondLast.getCoach().ToStringShort());
                    Coach temp = getRandomCoach();
                    secondLast.setCoach(temp);
                    Console.WriteLine("\tThey hired " + temp.ToStringShort());
                }
            }
        }

        public static double getWage(int min, int max)
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            double temp = rnd.getInt(min, max) + (rnd.getInt(1, 9) / 10.0);
            return Math.Round(temp, 2);
        }
    }
}

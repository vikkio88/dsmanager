using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public static class GameUtils
    {
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


    }
}

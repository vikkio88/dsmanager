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
            }
           
            return list;
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
            }

            return list;
        }

        public static void wait(int millisec= 5)
        {
            System.Threading.Thread.Sleep(millisec);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public static class GameUtils
    {
        public static List<Player> getRandomPlayersList(int n=1)
        {
            List<Player> list = new List<Player>();
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            for (int i = 0; i < n; i++)
            {
                list.Add(new Player(rnd.getName(), rnd.getSurname(),rnd.getAge(),rnd.getAvgSkill()));
                System.Threading.Thread.Sleep(5);
            }

            return list;
        }
    }
}

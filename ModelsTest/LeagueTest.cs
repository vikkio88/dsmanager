using DsManager.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTest
{
    [TestFixture]
    class LeagueTest
    {
        [Test]
        public void testAlgoritmoCampionato()
        {
            League a = new League(GameUtils.getRandomTeamsList(4));
            //a.ListMatches();
            for (int i = 0; i < 4; i++)
            {
                a.simulateRound();
               // a.printFixtureAt(i);
                Console.WriteLine("***********\n"+a.getTableString());
            }

            a.simulateRound();
            Console.WriteLine(a.getScorerTable());
            //a.printFixture();
            
        }

        [Test]
        public void TestPlayerFromLine()
        {
            List<Player> list = GameUtils.generatePlayersFromFile();
            foreach (Player item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }

        [Test]

        public void TestEvaluate()
        {
            int constant = 43;
            for (int i = 0; i < 20; i++)
            {
                Player temp = GameUtils.getRandomPlayersList().ElementAt(0);
                Console.WriteLine(temp.ToString());
                int c = evaluatePlayer(temp);
                Console.WriteLine("valutazione: "+c+"%");
                Console.WriteLine("prezzo finale: "+(temp.Val+(temp.Val * (c/100.0))));
                double probabilitytosell = constant + (100 - (temp.Age / 40.0 * 100));
                Console.WriteLine("probtosell: "+probabilitytosell);
                if (GameUtils.getProbability(Convert.ToInt32(probabilitytosell)))
                {
                    Console.WriteLine("Venduto");
                }
                else
                {
                    Console.WriteLine("Invenduto");
                }
                Console.WriteLine();
                GameUtils.wait();
            }
           

        }

        private int evaluatePlayer(Player tosell)
        {
            double perc = 100;
            Console.WriteLine("step1: "+perc);
            perc -= (100 - tosell.SkillAvg);
            Console.WriteLine("onskill: " + perc);
            perc -= ((tosell.Age / 40.0 * 100));
            Console.WriteLine("\tmodifier: " + (tosell.Age / 40.0 * 100));
            Console.WriteLine("onage: " + perc);


            return Convert.ToInt32(perc);
        }
    }
}

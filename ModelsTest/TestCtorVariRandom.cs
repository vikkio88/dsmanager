using DsManager.Models;
using RandomFiller;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsTest
{
    [TestFixture]
    class TestCtorVariRandom
    {
        [Test]
        public void GiocatoriCasuali()
        {
            RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
            Player uno = new Player(rndfl.getName(),rndfl.getSurname(),rndfl.getAge(),rndfl.getAvgSkill(),rndfl.getRole());
            Console.WriteLine(uno.ToString());

        }

        [Test]
        public void CreaSquadra()
        {
            RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
            Team sq = new Team("Banana UTD");
            for (int i = 0; i < 11; i++)
            {

                Player uno = new Player(rndfl.getName(), rndfl.getSurname(), rndfl.getAge(), rndfl.getAvgSkill(), rndfl.getRole());

                sq.addPlayer(uno);
                //Console.WriteLine(uno.ToString());
            }


            Console.WriteLine(sq.ToStringFull());

        }

        [Test]
        public void SimulazionePartita()
        {
            RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
            Team sq, sq1;
            if (rndfl.getInt(100) > 50)
            {
                sq = new Team("Milan");
                sq1 = new Team("Juventus");
            }
            else
            {
                sq1 = new Team("Milan");
                sq = new Team("Juventus");
            }
           // Team sq = new Team("Milan");
            for (int i = 0; i < 11; i++)
            {

                Player uno = new Player();
                uno.PlayerName = rndfl.getName();
                uno.PlayerSurname = rndfl.getSurname();
                uno.SkillAvg = rndfl.getInt(10, 100);
                uno.Age = rndfl.getInt(15, 39);

                sq.addPlayer(uno);
                //Console.WriteLine(uno.ToString());
            }


            Console.WriteLine(sq.ToString());

         //   RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
         //   Team sq1 = new Team("Juventus");
            for (int i = 0; i < 11; i++)
            {

                Player uno = new Player();
                uno.PlayerName = rndfl.getName();
                uno.PlayerSurname = rndfl.getSurname();
                uno.SkillAvg = rndfl.getInt(40, 100);
                uno.Age = rndfl.getInt(15, 39);

                sq1.addPlayer(uno);
                //Console.WriteLine(uno.ToString());
            }


            Console.WriteLine(sq1.ToString());

            Match partita = new Match(sq, sq1);
            Console.WriteLine(sq.TeamName+" - "+ sq1.TeamName+" "+ partita.Score().ToString());
            
        }

        [Test]
        public void TestSuTantePartite()
        {
            RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
            Team sq, sq1;
            for (int j = 0; j < 20; j++)
            {
                if (rndfl.getInt(100) > 50)
                {
                    sq = new Team("Milan");
                    sq1 = new Team("Juventus");
                }
                else
                {
                    sq1 = new Team("Milan");
                    sq = new Team("Juventus");
                }
                // Team sq = new Team("Milan");
                for (int i = 0; i < 11; i++)
                {

                    Player uno = new Player();
                    uno.PlayerName = rndfl.getName();
                    uno.PlayerSurname = rndfl.getSurname();
                    uno.SkillAvg = rndfl.getInt(40, 100);
                    uno.Age = rndfl.getInt(15, 39);

                    sq.addPlayer(uno);

                }

                for (int i = 0; i < 11; i++)
                {

                    Player uno = new Player();
                    uno.PlayerName = rndfl.getName();
                    uno.PlayerSurname = rndfl.getSurname();
                    uno.SkillAvg = rndfl.getInt(40, 100);
                    uno.Age = rndfl.getInt(15, 39);

                    sq1.addPlayer(uno);

                }




                Match partita = new Match(sq, sq1);
       
                Console.WriteLine("\n*********\n" + sq.getAvgTeam().ToString() + " : " + sq1.getAvgTeam().ToString());
                Console.WriteLine(sq.TeamName + " - " + sq1.TeamName + " " + partita.Score().ToString());
                System.Threading.Thread.Sleep(50);

            }

        }

        [Test]
        public void TestCTORPlayerConNazionalitaDiverse()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            Player pl = new Player(rnd.getName("Spain"), rnd.getSurname("Spain"),rnd.getAge(),rnd.getAvgSkill(),"Spain");
            Console.WriteLine(pl.ToString());
        }

        [Test]
        public void TestGameUtils()
        {
            List<Player> list = GameUtils.getRandomPlayersList(50);
            foreach (Player pl in list)
            {
                Console.WriteLine(pl.ToString());
            }

        }

        [Test]
        public void TestModuloEValidita()
        {
            Module m = new Module("4-4-2");
            List<Player> players = GameUtils.getRandomPlayersList(20);
            Team t = new Team("Ababa");
            foreach (Player item in players)
            {
                t.addPlayer(item);
            }
            Console.WriteLine(t.ToStringFull());
            if (m.check(t, m))
                Console.WriteLine("OK");
            else
                Console.WriteLine("Nope");
        }

        [Test]
        public void TestGiocatoriPerOgniRuoloperSquadra()
        {
            List<Player> players = GameUtils.getRandomPlayersList(20);
            Team t = new Team("Ababa");
            foreach (Player item in players)
            {
                t.addPlayer(item);
            }
            Console.WriteLine(t.ToStringFull());
            int[] plfr = Module.playersForRolesinTeam(t);
            List<string> rol = Module.getRoles();
            int length = plfr.Count();
            for (int i = 0; i < length; i++)
            {
                if (plfr[i] > 0)
                {
                    Console.WriteLine(rol.ElementAt(i)+" : "+plfr[i].ToString());
                }
            }
            
        }
    }
}

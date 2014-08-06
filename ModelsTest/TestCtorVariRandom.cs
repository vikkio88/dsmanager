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
            Player uno = new Player();
            uno.PlayerName = rndfl.getName();
            uno.PlayerSurname = rndfl.getSurname();
            uno.SkillAvg = rndfl.getInt(30, 100);
            uno.Age = rndfl.getInt(15, 39);
            Console.WriteLine(uno.ToString());

        }

        [Test]
        public void CreaSquadra()
        {
            RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
            Team sq = new Team("Banana UTD");
            for (int i = 0; i < 11; i++)
            {
               
                Player uno = new Player();
                uno.PlayerName = rndfl.getName();
                uno.PlayerSurname = rndfl.getSurname();
                uno.SkillAvg = rndfl.getInt(40, 100);
                uno.Age = rndfl.getInt(15, 39);

                sq.addPlayer(uno);
                //Console.WriteLine(uno.ToString());
            }


            Console.WriteLine(sq.ToString());

        }

        [Test]
        public void SimulazionePartita()
        {
            RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
            Team sq = new Team("Milan");
            for (int i = 0; i < 11; i++)
            {

                Player uno = new Player();
                uno.PlayerName = rndfl.getName();
                uno.PlayerSurname = rndfl.getSurname();
                uno.SkillAvg = rndfl.getInt(40, 100);
                uno.Age = rndfl.getInt(15, 39);

                sq.addPlayer(uno);
                //Console.WriteLine(uno.ToString());
            }


            Console.WriteLine(sq.ToString());

         //   RandomFiller.RandomFiller rndfl = new RandomFiller.RandomFiller();
            Team sq1 = new Team("Juventus");
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
    }
}

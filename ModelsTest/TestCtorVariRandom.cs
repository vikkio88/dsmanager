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
    }
}

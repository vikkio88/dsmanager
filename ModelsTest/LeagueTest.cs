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
            League a = new League(GameUtils.getRandomTeamsList(10));
            a.ListMatches();
            Console.WriteLine("*******************\n\n\n");
            a.printFixtureAt(0);
            Console.WriteLine("*******************\n\n\n");
            a.simulateRound();
            a.printFixtureAt(0);
            Console.WriteLine("*******************\nCLASSIFICA\n\n" + a.getTableString());
            a.simulateRound();
            a.printFixtureAt(1);
            Console.WriteLine("*******************\nCLASSIFICA\n\n" + a.getTableString());
            a.simulateRound();
            a.printFixtureAt(2);
            Console.WriteLine("*******************\nCLASSIFICA\n\n" + a.getTableString());
            //a.printFixture();
            
        }
    }
}

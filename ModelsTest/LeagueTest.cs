﻿using DsManager.Models;
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
    }
}

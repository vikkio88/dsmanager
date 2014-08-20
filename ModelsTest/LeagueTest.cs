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
            a.ListMatches(a.leagueTeams);
        }
    }
}

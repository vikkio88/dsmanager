using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    class Round
    {
        public List<Match> matches;
        public string Description { get; set; }

        public Round()
        {
            Description = "";
            matches = new List<Match>();
        }

        public Round(string name)
        {
            Description = name;
            matches = new List<Match>();
        }

        public Match getMatchAt(int n = 0)
        {
            return matches.ElementAt(n);
        }

    }
}

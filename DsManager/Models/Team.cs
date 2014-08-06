using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public class Team
    {
        private string teamName;
        private List<Player> players;
        private Coach coach;



        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
        


       

    }
}

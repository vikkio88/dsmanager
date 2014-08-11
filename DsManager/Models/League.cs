using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsManager.Models
{
    public class League
    {
 

        public List<Team> leagueTeams;
        public Dictionary<Team, int> table;
        public MyDictionary scorers;
        int roundsnumber = 0;
        int currentround = 0;

        public League(List<Team> Teamlist)
        {
            if ((Teamlist.Count % 2) != 0)
            {
                throw new Exception("Must be a pair number of teams");
            }

            leagueTeams = Teamlist;
            table = new Dictionary<Team, int>();
            foreach (Team t in Teamlist)
            {
                table.Add(t, 0);
            }

            roundsnumber = leagueTeams.Count - 1;

        }

        public void generateFixture()
        {

        }

        public void simulateRound()
        {
            List<Match> results = new List<Match>();

            foreach (Match m in results)
            {
                m.Score();
            }

            refreshTable(results);
           // refreshScorers(results);
        }

        public string getTableString()
        {
            string res = "";

            int c = 1;
            foreach (KeyValuePair<Team, int> pair in table)
            {
                res += c.ToString()+". "+pair.Key.TeamName + " --- " + pair.Value+"\n";
                c++;
            }


            return res;
        }

        private void refreshScorers(List<Match> results)
        {
            foreach (Match m in results)
            {
                foreach (Player pl in m.Result.scorerHome)
                {
                    addToScorer(pl,m.HomeTeam);
                }
                foreach (Player pl in m.Result.scorerAway)
                {
                    addToScorer(pl, m.AwayTeam);
                }
            }
        }

        private void addToScorer(Player pl, Team team)
        {
            //Attenzione possono esistere giocatori con lo stesso nome in
            //squadre diverse

            if (!scorers.ContainsKey(pl))
            {
                scorers.Add(pl, team.TeamName, 1);
            }
            else
            {
                TeamGoals temp = scorers[pl];
                temp.goals += 1;
                scorers[pl] = temp;
            }
        }

        private void refreshTable(List<Match> results)
        {
            foreach (Match m in results)
            {
                if (!m.Draw())
                {
                    table[m.Winner()] += 3;
                }
                else
                {
                    table[m.HomeTeam] += 1;
                    table[m.AwayTeam] += 1;
                }
            }
        }

    public void AlgoritmoDiBerger(List<Team> squadre1){
    List<string> squadre2 = new List<string>();
    foreach (Team item in squadre1)
	{
		 squadre2.Add(item.TeamName);
	}
        string[] squadre = squadre2.ToArray();
    int numero_squadre = squadre.Count();
    int giornate = numero_squadre - 1;
 
    /* crea gli array per le due liste in casa e fuori */
    String[] casa = new String[numero_squadre /2];
    String[] trasferta = new String[numero_squadre /2];
 
    for (int i = 0; i < numero_squadre /2; i++) {
        casa [i] = squadre.[i]; 
        trasferta[i] = squadre[numero_squadre - 1 - i]; 
    }
 
    for (int i = 0; i < giornate; i++) {
        /* stampa le partite di questa giornata */
        //System.out.printf("%d^ Giornata\n",i+1);
        Console.WriteLine(i+1+" giornata");
 
        /* alterna le partite in casa e fuori */
        if (i % 2 == 0) {
            for (int j = 0; j < numero_squadre /2 ; j++)
                 Console.WriteLine("{0}  {1} - {2}\n", j+1, trasferta[j], casa[j]); 
        }
        else {
            for (int j = 0; j < numero_squadre /2 ; j++) 
                 Console.WriteLine("{0}  {1} - {2}\n", j+1, casa[j], trasferta[j]); 
        }
 
        // Ruota in gli elementi delle liste, tenendo fisso il primo elemento
        // Salva l'elemento fisso
        String pivot = casa [0];
 
        /* sposta in avanti gli elementi di "trasferta" inserendo 
           all'inizio l'elemento casa[1] e salva l'elemento uscente in "riporto" */
        String riporto = shiftRight(trasferta, casa [1]); 
 
        /* sposta a sinistra gli elementi di "casa" inserendo all'ultimo 
           posto l'elemento "riporto" */
        shiftLeft(casa, riporto);
 
        // ripristina l'elemento fisso
        casa[0] = pivot ;
    } 
}



    }
    public struct TeamGoals
    {
        public string TeamName;
        public int goals;
    }

    public class MyDictionary : Dictionary<Player, TeamGoals>
    {
        public void Add(Player pl, string tname, int goals)
        {
            TeamGoals tg;
            tg.TeamName = tname;
            tg.goals = goals;
            this.Add(pl, tg);

        }
    }
}

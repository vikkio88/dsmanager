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
            Team t = new Team("Juventus");
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


        [Test]
        public void TestCoach()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();

            Coach erminio = new Coach(rnd.getName(), rnd.getSurname(), rnd.getAvgSkill(),rnd.getModules());
            Console.WriteLine(erminio.ToString());
        }
        [Test]
        public void TestRandomTeamName()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(rnd.getTeamName());
                GameUtils.wait(20);
            }
        }

        [Test]
        public void TestSquadraConAllenatore()
        {
            Team a = GameUtils.getRandomTeamsList().First();

            Console.WriteLine(a.ToStringFull());
            string[] r = Module.getRoles().ToArray();
            
            int[] plfr = a.getPlayersPerRoles();
            int length = plfr.Count();

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(r[i]+" : "+plfr[i]);    
            }
        }
        
        [Test]
        public void testSimulazionePartitaCasuale()
        {
            List<Team> list = GameUtils.getRandomTeamsList(2);
            Team a = list.ElementAt(0);
            Team b = list.ElementAt(1);
          
            /*
            Team b = new Team("Juventus FC");
            b.addPlayers(GameUtils.getRandomPlayersList(20));
            */

            Match m = new Match(a, b);
            Console.WriteLine(a.ToStringFull());
            Console.WriteLine(b.ToStringFull());
            Console.WriteLine("\n*********\n" + a.Avg + " : " + b.Avg);
            Console.WriteLine(a.TeamName + " - " + b.TeamName + " " + m.Score().ToString());

            
        }
        
        [Test]
        public void testGetGiocatorePerRuolo()
        {
            Player giocatore = GameUtils.getRandomPlayersPerRole("AC").First();
            Console.WriteLine(giocatore.ToString());
        }

        [Test]
        public void TestValoreGiocatoriReali()
        {
            Player giocatore = new Player("Paul", "Pogba", 21, 79, "CC", "Francese");
            Console.WriteLine(giocatore.ToString());
            giocatore = new Player("Arturo", "Vidal", 28, 85, "CC", "Cileno");
            Console.WriteLine(giocatore.ToString());
            giocatore = new Player("Lionel", "Messi", 27, 95, "AS", "Argentino");
            Console.WriteLine(giocatore.ToString());
            giocatore = new Player("Robin", "VanPersie", 31, 89, "AC", "Olandese");
            Console.WriteLine(giocatore.ToString());
            giocatore = new Player("Alvaro", "Morata", 22, 76, "AC", "Spagnolo");
            Console.WriteLine(giocatore.ToString());
        }

        [Test]
        public void TestGiocatoriCasualiPerModulo()
        {
            List<Player> giocatori = GameUtils.getRandomPlayersForModule(new Module("4-2-4"));

            foreach (Player item in giocatori)
            {
                Console.WriteLine(item.ToString());
            }
        }

        [Test]
        public void TestPartitaConSquadreConModuloAdatto()
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();
            Team a = new Team(rnd.getTeamName());
            GameUtils.wait();
            Team b = new Team(rnd.getTeamName());
            List<Coach> coachl = GameUtils.getRandomCoachList(2);

            a.setCoach(coachl.ElementAt(0));
            b.setCoach(coachl.ElementAt(1));

            a.addPlayers(GameUtils.getRandomPlayersForModule(coachl.ElementAt(0).FavouriteModule));
            b.addPlayers(GameUtils.getRandomPlayersForModule(coachl.ElementAt(1).FavouriteModule));

            Match m = new Match(a, b);
            Console.WriteLine(a.ToStringFull());
            Console.WriteLine(b.ToStringFull());
            Console.WriteLine("\n*********\n" + a.Avg + " : " + b.Avg);
            Console.WriteLine(a.TeamName + " - " + b.TeamName + " " + m.Score().ToString());

        }

        [Test]
        public void TestPartitaConGiocatoriVeri()
        {
            Team juve = new Team("Juventus FC");
            Coach all = new Coach("Massimiliano", "Allegri", 80, "4-3-3");
            juve.setCoach(all);

            List<Player> juvteam = new List<Player>(){
                                                        new Player("Gigi","Buffon",36,87,"PT"),
                                                        new Player("Patrice","Evrá",33,82,"DS"),
                                                        new Player("Giorgio","Chiellini",30,86,"DC"),
                                                        new Player("Andrea","Barzagli",33,84,"DC"),
                                                        new Player("Paul", "Pogba", 21, 80, "CC", "Francese"),
                                                        new Player("Andrea", "Pirlo", 35, 87, "CC"),
                                                        new Player("Arturo", "Vidal", 28, 85, "CC", "Cileno"),
                                                        new Player("Kwadwo", "Asamoah", 26, 80, "AS", "Ghanese"),
                                                        new Player("Stephen", "Lichsteiner", 30, 80, "DD", "Svizzero"),
                                                        new Player("Carlitos", "Tevez", 30, 88, "AD", "Argentino"),
                                                        new Player("Fernando", "Llorente", 29, 82, "AC", "Spagnolo")
                                                        };
            juve.addPlayers(juvteam);

          /*  Module mod = all.FavouriteModule;

            Console.WriteLine("Modulo: " + mod.check(juve).ToString());*/

            Team milan = new Team("AC Milan");
            Coach all1 = new Coach("Filippo", "Inzaghi", 70, "4-4-2");
            milan.setCoach(all1);
            List<Player> milteam = new List<Player>(){
                                                        new Player("Christian","Abbiati",37,80,"PT"),
                                                        new Player("Kevin","Constant",27,78,"DD"),
                                                        new Player("Mattia","De Sciglio",22,78,"DS"),
                                                        new Player("Daniele","Bonera",33,77,"DC"),
                                                        new Player("Amil", "Rami", 29, 82, "DC", "Francese"),
                                                        new Player("Riccardo", "Montolivo", 29, 84, "CC"),
                                                        new Player("Keisuke", "Honda", 28, 81, "CC", "Giapponese"),
                                                        new Player("Neigel", "De Jong", 30, 79, "CC", "Olandese"),
                                                        new Player("Michael", "Essien", 32, 81, "CC", "Ghanese"),
                                                        new Player("Stephan", "El Shaarawy", 22, 81, "AC"),
                                                        new Player("Mario", "Balotelli", 24, 84, "AC")
                                                        };
            milan.addPlayers(milteam);


            //Partita
            Match m = new Match(juve, milan);
            Console.WriteLine(juve.ToStringFull());
            Console.WriteLine(milan.ToStringFull());
            Console.WriteLine("\n*********\n" + juve.Avg + " : " + milan.Avg);
            Console.WriteLine(juve.TeamName + " - " + milan.TeamName + " " + m.Score().ToString());

        }

        [Test]
        public void TestSimulazioniTantePartiteCasuali()
        {
            for (int i = 0; i < 10; i++)
            {


                List<Team> list = GameUtils.getRandomTeamsList(2);
                Team a = list.ElementAt(0);
                Team b = list.ElementAt(1);

                /*
                Team b = new Team("Juventus FC");
                b.addPlayers(GameUtils.getRandomPlayersList(20));
                */

                Match m = new Match(a, b);
                //  Console.WriteLine(a.ToStringFull());
                //   Console.WriteLine(b.ToStringFull());
                Console.WriteLine("\n*********\n" + a.Avg + " : " + b.Avg);
                Console.WriteLine(a.TeamName + " - " + b.TeamName + " " + m.Score().ToStringTiny());
            }
        }

        [Test]
        public void TestOrdinamentoTeam()
        {
            List<Team> lt = GameUtils.getRandomTeamsList(5);
            foreach (Team item in lt)
            {
                Console.WriteLine(item.TeamName+" "+item.Avg);
            }
            
            lt.Sort();
            Console.WriteLine("************");
            foreach (Team item in lt)
            {
                Console.WriteLine(item.TeamName + " " + item.Avg);
            }
        }

        
        [Test]
        public void TestPartitaConRigori()
        {
            Team a = GameUtils.getRandomTeamsList().First();
            Team b = GameUtils.getRandomTeamsList().First();

            Match m = new Match(a, b);
            Console.WriteLine(a.TeamName+" - "+b.TeamName+" "+m.Score().ToString());

            if (m.Draw())
            {
                Console.WriteLine("Pareggio, ai rigori");
                m.Penalties();
                Console.WriteLine("dopo i rigori vince:");
                Console.WriteLine(m.Winner().TeamName);
            }
         
            
        }

        [Test]
        public void TestPlayerForRoleFromRandomTeam()
        {
            Team a = GameUtils.getRandomTeamsList().First();
            Player p;
            try
            {
                p = a.getPlayerForRole("PT");
                Console.WriteLine(p.ToString());
               
            }
            catch (Exception e)
            {
                Console.WriteLine("Nessun portiere in squadra: "+ e.Message);
                
            }
            
        }

        [Test]
        public void PrimoTestLeague()
        {
            League l = new League(GameUtils.getRandomTeamsList(4));
            Console.WriteLine(l.getTableString());
        }


    }
}

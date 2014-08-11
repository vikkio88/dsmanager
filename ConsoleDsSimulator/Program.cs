using DsManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDsSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            double euro = 10;
            int num = 0;

            StampaBanner();
            Console.ReadKey();
            char q='0';
            while(q!='q'){
                num++;
                double scommessa = 0.0;
                euro = Math.Round(euro,2);
                Console.Clear();
                List<Team> TeamList = GameUtils.getRandomTeamsList(4);
                double[] quote = CalcolaQuote(TeamList);
                Team fav;
                Console.WriteLine("Partita numero: "+num);
                Console.WriteLine("Abbiamo le seguenti squadre:");
                int c = 1;
                foreach (Team team in TeamList)
                {
                    Console.WriteLine(c+".  "+team.TeamName+" media: "+ team.Avg +"%" + "\tquota: "+quote[c-1]);
                    c++;
                }

                Console.Write("Hai "+euro.ToString()+" Euro\n su quale scommetti?  > ");
                try
                {
                    c= int.Parse(Console.ReadLine());
                    fav = TeamList.ElementAt(c - 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Niente hai sbagliato, scelto io per te... la prima");
                    c=1;
                    fav = TeamList.ElementAt(0);
                }
                Console.WriteLine("\t\t---> " + fav.TeamName);
                
                while (!((scommessa <= euro)&&(scommessa!=0.0)&&(scommessa>0)))
                {
                    Console.WriteLine("Quanti euro scommetti?");
                    scommessa = double.Parse(Console.ReadLine());
                    if (scommessa > euro)
                    {
                        Console.WriteLine("Accettiamo solo contanti...");
                    }

                    if (scommessa == 0.0 || scommessa < 0.0)
                    {
                        Console.WriteLine("E che minchia sei venuto a scommettere?");
                    }
                }

                Console.WriteLine("\t\tscommessa piazzata---> " + fav.TeamName + " - Winner:" + quote[c - 1] + " x " + scommessa + " EUR");

                RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();

                Team f1;
                Team f2;
                Console.WriteLine("Semifinali");

                GameUtils.wait(1000);

                Match sf1 = new Match(TeamList.ElementAt(0), TeamList.ElementAt(1));
               // Console.WriteLine("\n*********\n" + TeamList.ElementAt(0).Avg + " : " + TeamList.ElementAt(1).Avg);
                Console.Write(TeamList.ElementAt(0).TeamName + " - " + TeamList.ElementAt(1).TeamName + " ");
           
                GameUtils.wait(2000);
                Console.WriteLine(sf1.Score().ToStringTiny());
            
                if (!sf1.Draw())
                {
                    f1 = sf1.Winner();
                    Console.WriteLine("\tvince: " + f1.TeamName);
                }
                else
                {
                    Console.Write("Dopo i rigori...");
                    f1 = TeamList.ElementAt(rnd.getInt(1));
                    Console.WriteLine("\tvince: "+ f1.TeamName);
                }
                Console.WriteLine("Enter per continuare");
                Console.ReadLine();

                Match sf2 = new Match(TeamList.ElementAt(2), TeamList.ElementAt(3));
               // Console.WriteLine("\n*********\n" + TeamList.ElementAt(2).Avg + " : " + TeamList.ElementAt(3).Avg);
                Console.Write(TeamList.ElementAt(2).TeamName + " - " + TeamList.ElementAt(3).TeamName + " ");
                GameUtils.wait(2000);
                Console.WriteLine(sf2.Score().ToStringTiny());
                if (!sf2.Draw())
                {
                    f2 = sf2.Winner();
                    Console.WriteLine("\tvince: " + f2.TeamName);
                }
                else
                {
                    Console.Write("Dopo i rigori...");
                    f2 = TeamList.ElementAt(rnd.getInt(2,3));
                    Console.WriteLine("\tvince: " + f2.TeamName);
                }

                Console.WriteLine("Enter per continuare");
                Console.ReadLine();

                Team W;
                Console.WriteLine("Finale");
                Match f = new Match(f1,f2);
              //  Console.WriteLine("\n*********\n" + f1.Avg + " : " + f2.Avg);
                Console.Write(f1.TeamName + " - " + f2.TeamName + " ");
                GameUtils.wait(2000);
                Console.WriteLine(f.Score().ToStringTiny());
                if (!f.Draw())
                {
                    W = f.Winner();
                }
                else
                {
                    Console.Write("Dopo i rigori...");
                    if (rnd.getInt(100) > 50)
                    {
                        W = f1;
                    }
                    else
                    {
                        W = f2;
                    }
                    Console.WriteLine("vince: " + W.TeamName);
                }

                Console.WriteLine("\t\tVince il torneo: "+W.TeamName);
                GameUtils.wait(1000);
                Console.WriteLine("**************************");
                Console.WriteLine("Tu avevi scommesso su: "+fav.TeamName);
                GameUtils.wait(1000);
                
                if (fav.TeamName == W.TeamName)
                {
                    Console.WriteLine("Hai vinto "+quote[c-1]+" Euro");
                    euro += scommessa * quote[c - 1];
                }
                else
                {
                    Console.WriteLine("Hai perso");
                    euro -= scommessa;
                }

                if (euro < 1.0)
                {
                    gameover(euro, num);
                }

                Console.WriteLine("\n\nTi rimangono "+euro+" Euro\nEnter per giocare di nuovo, inserisci 'q' per uscire");
               
                try
                {
                    q = char.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    q= '0';
                }


            }
            gameover(euro, num);


        }

        private static void gameover(double euro, int num)
        {
            euro = Math.Round(euro, 2);
            Console.Clear();
            Console.WriteLine("Hai giocato " + num + " partite e ti sono rimasti "+euro+" Euro\n alla prossima ;)");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private static double[] CalcolaQuote(List<Team> TeamList)
        {
            RandomFiller.RandomFiller rnd = new RandomFiller.RandomFiller();

            int max;
            int min;
            List<double> quote = new List<double>();
            TeamList.Sort();
            max=TeamList.ElementAt((TeamList.Count-1)).Avg;
            min = TeamList.ElementAt(0).Avg;

            if (max - min > 10)
            {
                double quota = rnd.getInt(4, 6) + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);
                quota = rnd.getInt(2, 4) + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);
                quota = rnd.getInt(1, 2) + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);
                quota = 1 + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);

            }
            else
            {
                double quota = rnd.getInt(2, 3) + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);
                quota = rnd.getInt(1, 3) + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);
                quota = rnd.getInt(1, 2) + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);
                quota = 1 + (rnd.getInt(1, 8) / 10.0);
                quote.Add(quota);

            }

            return quote.ToArray();
        }

        private static void StampaBanner()
        {
            Console.WriteLine("***********************\n\tFootballBet\n\tSimulator\n***********************\n");
        }
    }
}

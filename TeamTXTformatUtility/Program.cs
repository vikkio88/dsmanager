using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTXTformatUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input;
            Console.Write("TeamName: ");
            input = Console.ReadLine();
            string file = input+".txt";
            string c = "s";
            while (c == "s")
            {
                Console.Clear();
                Console.WriteLine("Giocatori Inseriti: "+count);
                string tmp;
                input = "";
                //string must have this sintax Name:Surname:Age:Skill:Role:Nation
                Console.Write("Nome: ");
                tmp = Console.ReadLine();
                processText(ref tmp);
                input+=tmp+":";
                
                Console.Write("Cognome: ");
                tmp = Console.ReadLine();
                processText(ref tmp);
                input += tmp + ":";

                Console.Write("Eta': ");
                tmp = Console.ReadLine();
                input += tmp + ":";

                Console.Write("MediaVoto: ");
                tmp = Console.ReadLine();
                input += tmp + ":";

                Console.Write("Ruolo: ");
                tmp = Console.ReadLine();
                processText(ref tmp,true);
                input += tmp + ":";

                Console.Write("Nazionalita': ");
                tmp = Console.ReadLine();
                processText(ref tmp);
                input += tmp;

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(file, true))
                {
                    writer.WriteLine(input);
                }
                
                count++;
                Console.WriteLine("Altro giocatore? [s/n]");
                c = Console.ReadLine();
            }
        }

        private static void processText(ref string tmp, bool p=false)
        {
            if (!p)
            {
                tmp = UppercaseFirst(tmp);
            }
            else
            {
                tmp = tmp.ToUpper();
            }
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleUtils
{
    public static class MyConsole
    {

        public static string AskForFullName()
        {
            bool done = false;

            string ret = "";

            while (!done)
            {
                ret = Console.ReadLine();
                if (!(Regex.Match(ret,@"\w+\s\w+").Success)) 
                {
                    Console.WriteLine("Not a valid full name!");
                }
                else
                {
                    done = true;
                }
            }

            return ret;
        }
        public static double AskForDouble(double max)
        {
            bool done = false;

            double ret = 1.0;

            while (!done)
            {
                Console.Write("[1/" + max + "] > ");
                try
                {
                    ret = int.Parse(Console.ReadLine());
                    if (ret > max)
                    {
                        throw new Exception("Not a Valid choose!");
                    }

                    if (ret < 1)
                    {
                        throw new Exception("Not a Valid choose!");
                    }
                    done = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    done = false;
                }
            }

            return ret;
        }
        public static int AskForInt(int max)
        {
            bool done = false;

            int ret=1;
            
            while (!done)
            {
                Console.Write("[1/" + max + "] > ");
                try
                {
                    ret = int.Parse(Console.ReadLine());
                    if (ret > max)
                    {
                        throw new Exception("Not a Valid choose!");
                    }

                    if (ret < 1)
                    {
                        throw new Exception("Not a Valid choose!");
                    }
                    done = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    done = false;
                }
            }

            return ret;
        }
    }
}

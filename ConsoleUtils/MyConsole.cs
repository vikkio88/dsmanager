using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtils
{
    public static class MyConsole
    {
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

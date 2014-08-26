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
            int ret;
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
            }
            catch (Exception e)
            {
                ret = max;
            }
            return ret;
        }
    }
}

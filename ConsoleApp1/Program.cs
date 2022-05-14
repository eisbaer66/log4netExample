using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetLogger(typeof(Program));

            try
            {
                logger.Error("TEST");
            }
            finally
            {
                LogManager.Flush(1000);
            }

        }
    }
}

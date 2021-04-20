using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_1
{
    public class Logger
    {
        int numberOfLines = 0;
        private static Logger uniqueInstance;

        // Constructor not available
        private Logger() { }


        public static Logger GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }

            return uniqueInstance;
        }

        public void Log(string systeem, string logregel)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Cyan;
            numberOfLines++;
            Console.WriteLine(String.Format("{0} - [{1}] {2}", numberOfLines, systeem, logregel));
        }
    }
}

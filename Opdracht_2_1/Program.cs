using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CallDataLoader call = new CallDataLoader();
            TwitterDataLoader twitter = new TwitterDataLoader();
            SensorDataLoader sensor = new SensorDataLoader();

            BatchProcessor batchprocessor = new BatchProcessor();
            batchprocessor.Add(call);
            batchprocessor.Add(twitter);
            batchprocessor.Add(sensor);

            batchprocessor.Process();

            Console.ReadKey();
        }
    }
}

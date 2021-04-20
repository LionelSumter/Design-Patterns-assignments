using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_1
{
    public class BatchProcessor
    {
        public List<BigDataLoader> bigDataLoaderList = new List<BigDataLoader>();

        public void Add(BigDataLoader bigdataloader)
        {
            bigDataLoaderList.Add(bigdataloader);
        }

        public void Process()
        {
            foreach(BigDataLoader bigdataloader in bigDataLoaderList)
            {
                bigdataloader.ETL();
            }
        }
    }
}

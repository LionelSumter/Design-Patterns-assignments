using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_1
{
    public abstract class BigDataLoader
    {
        public void ETL()
        {
            Extract();
            Transform();
            Load();
        }

        public abstract void Extract();
        public abstract void Transform();
        public abstract void Load();
    }
}

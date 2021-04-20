using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_extra.Models
{
    public interface ISongObserver
    {
        void Update(Song song);
    }
}

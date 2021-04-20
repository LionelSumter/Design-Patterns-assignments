using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_3_1.Models;

namespace Opdracht_3_1.Controllers
{
    public interface ITreinController
    {
        ITreinreis treinreis { get; }
        void VolgendStation();
    }
}

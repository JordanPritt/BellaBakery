using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBakery.Models
{
    public interface IPieRepo
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int id);
    }
}

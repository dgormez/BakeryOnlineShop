using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryOnlineShop.Model
{
    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }

        IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie GetPieById ( int pieId );
    }
}

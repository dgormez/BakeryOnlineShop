using System.Collections.Generic;
using BakeryOnlineShop.Model;

namespace BakeryOnlineShop.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BakeryOnlineShop.Model;

namespace BakeryOnlineShop.ViewModel
{
    public class PieViewModel
    {
        public int PieId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageThumbnailUrl { get; set; }


    }
}

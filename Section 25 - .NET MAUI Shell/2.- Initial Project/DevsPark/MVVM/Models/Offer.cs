using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark.MVVM.Models
{
    public class Offer
    {
        public int BusinessId { get; set; }
        public string OfferName { get; set; }
        public string Image { get; set; }
        public int Discount { get; set; }
        public string Description { get; set; }
    }
}

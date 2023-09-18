using DevsPark.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark
{
    public class OffersService
    {
        public List<Offer> Offers { get; set; } = new List<Offer>();
        public OffersService()
        {
            for (int i = 0; i < 5; i++)
            {
                Offers.Add(new Offer
                {
                    BusinessId = 1,
                    Image = "offer.jpg",
                    Discount = i * 5,
                    Description = $"Travel deal {i + 1}",
                    OfferName = $"Travel Offer {i + 1}"
                });
            }

            for (int i = 0; i < 5; i++)
            {
                Offers.Add(new Offer
                {
                    BusinessId = 2,
                    Image = "offer.jpg",
                    Discount = (i * 5) + 5,
                    Description = $"Hotel deal {i + 1}",
                    OfferName = $"Hotel Offer {i + 1}"
                });
            }

            for (int i = 0; i < 5; i++)
            {
                Offers.Add(new Offer
                {
                    BusinessId = 3,
                    Image = "offer.jpg",
                    Discount = (i * 5) + 10,
                    Description = $"Supermarket deal {i + 1}",
                    OfferName = $"Supermarket Offer {i + 1}"
                });
            }

            for (int i = 0; i < 5; i++)
            {
                Offers.Add(new Offer
                {
                    BusinessId = 4,
                    Image = "offer.jpg",
                    Discount = (i * 5) + 15,
                    Description = $"Clothing deal {i + 1}",
                    OfferName = $"Clothing Offer {i + 1}"
                });
            }
        }

        public List<Offer> GetOffers(int businessId)
        {
            return Offers.Where(o => o.BusinessId == businessId).ToList();
        }

    }
}

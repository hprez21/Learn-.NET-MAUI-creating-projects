using DevsPark.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark.Search
{
    public class OffersSearchHandler : SearchHandler
    {

        public List<Offer>  Suggestions { get; set; } = new List<Offer>();

        public OffersSearchHandler()
        {
            var service = Application.Current.MainPage
                .Handler
                .MauiContext
                .Services.GetService<OffersService>();

            Suggestions = service.Offers;

            ItemsSource = Suggestions;
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            if(string.IsNullOrEmpty(newValue))
            {
                ItemsSource = Suggestions;
            }
            else
            {
                ItemsSource = Suggestions
                    .Where(offer => offer.OfferName.ToLower().Contains(newValue.ToLower()))
                    .ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            var offers = new ObservableCollection<Offer>
            {
                item as Offer
            };

            var navigationParameter = new Dictionary<string, object>
            {
                { "offers", offers }
            };

            await Shell.Current.GoToAsync($"offersView", navigationParameter);
        }

    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevsPark.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark.MVVM.ViewModels
{
    //[QueryProperty(nameof(CompanyName), "name")]
    public partial class OffersViewModel : ObservableObject, IQueryAttributable
    {
        [ObservableProperty]
        ObservableCollection<Offer> offers;

        [ObservableProperty]
        string companyName = "Company Name";

        private readonly OffersService offersService;

        public OffersViewModel(OffersService _offersService)
        {
            offersService = _offersService;
        }


        [RelayCommand]
        public async Task Back()
        {
            await Shell.Current.DisplayAlert("Back pressed", "Back pressed", "OK");
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if(!query.ContainsKey("offers"))
            {
                var companyId = query["id"].ToString();
                CompanyName = Uri.UnescapeDataString(query["name"].ToString());
                Offers = new ObservableCollection<Offer>(offersService.GetOffers(int.Parse(companyId)));
            }
            else
            {
                Offers = query["offers"] as ObservableCollection<Offer>;
            }
        }
    }
}

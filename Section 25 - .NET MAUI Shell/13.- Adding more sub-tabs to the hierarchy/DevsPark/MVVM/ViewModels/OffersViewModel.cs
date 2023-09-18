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
    public partial class OffersViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Offer> offers;
        
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
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevsPark.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark.MVVM.ViewModels
{
    public partial class FeaturedViewModel : ObservableObject
    {
        [ObservableProperty]
        FeaturedPromotion selectedItem;
        public List<FeaturedPromotion> Promos { get; set; }

        public FeaturedViewModel()
        {
            Promos = new List<FeaturedPromotion>
            {
                new FeaturedPromotion
                {
                    BusinessId = 1,
                    BusinessName = "VoyageVista",
                    Image = "voyagevista.png",
                    Description = "Explore the world with VoyageVista. Your adventures await!"
                },
                new FeaturedPromotion
                {
                    BusinessId = 2,
                    BusinessName = "LuxLoom Hotels",
                    Image = "luxloom.png",
                    Description = "Luxury stays that feel like home. Book with LuxLoom."
                },
                new FeaturedPromotion
                {
                    BusinessId = 3,
                    BusinessName = "UrbanUmbra Stores",
                    Image = "urbanumbra.png",
                    Description = "Shop fresh, live healthy. Find everything you need at UrbanUmbra."
                },
                new FeaturedPromotion
                {
                    BusinessId = 4,
                    BusinessName = "ChicChase Outlets",
                    Image = "chicchase.png",
                    Description = "Define your style with the latest trends at ChicChase."
                }
            };
        }

        [RelayCommand]
        public async Task SelectionChanged()
        {
            await Shell.Current.GoToAsync($"offersView?id={selectedItem.BusinessId}&name={selectedItem.BusinessName}");
        }
    }
}

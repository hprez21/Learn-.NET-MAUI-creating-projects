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
    public partial class PlacesViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Place> places;

        [ObservableProperty]
        Place currentPlace;

        [ObservableProperty]
        bool isFlyoutOpen;

        public PlacesViewModel()
        {
            Places = new ObservableCollection<Place>
            {
                new Place
                {
                    Name = "Wave Pool",
                    Description = "Experience the fun and excitement of our amazing Wave Pool! Whether you're looking to surf the waves or simply relax, there's something for everyone. Safety guidelines apply, so please be cautious and ensure you're well-informed before diving in.",
                    ImagePath = "wave_pool.jpg"
                },
                new Place
                {
                    Name = "Surf Lessons",
                    Description = "Learn to ride the waves like a pro with our Surf Lessons! Our experienced instructors will guide you through the basics and help you catch those perfect waves. Whether you're a beginner or looking to improve your skills, our lessons are tailored for all levels.",
                    ImagePath = "surf_lessons.jpg"
                },
                new Place
                {
                    Name = "Zip Lines",
                    Description = "Soar through the sky and experience an adrenaline rush like no other on our Zip Lines! With breathtaking views of the park, you'll get a bird's-eye perspective of all the attractions. Our zip lines are safe and secure, ensuring an unforgettable adventure for all thrill-seekers.",
                    ImagePath = "zip_lines.jpg"
                },
                new Place
                {
                    Name = "Animal Shows",
                    Description = "Get up close and personal with incredible wildlife at our Animal Shows! From majestic birds to playful mammals, our trained handlers will showcase the beauty and intelligence of these creatures. It's an educational and entertaining experience for visitors of all ages.",
                    ImagePath = "animal_shows.jpg"
                },
                new Place
                {
                    Name = "Snowboarding",
                    Description = "Hit the slopes and experience the thrill of snowboarding at our Snowboarding park! Whether you're a seasoned snowboarder or a beginner, our slopes cater to all skill levels. Enjoy the winter wonderland and perfect your moves on the powder-covered hills.",
                    ImagePath = "snowboarding.jpg"
                },
                new Place
                {
                    Name = "Ice Sculptures",
                    Description = "Marvel at the exquisite artistry of our Ice Sculptures! Our talented sculptors create intricate designs that will leave you in awe. From delicate animals to towering ice castles, these sculptures are a true testament to the beauty of ice as a medium.",
                    ImagePath = "ice_sculptures.jpg"
                },
                new Place
                {
                    Name = "Ice Cream World",
                    Description = "Indulge your sweet tooth at Ice Cream World, where endless flavors and toppings await! From classic favorites to innovative creations, there's a frozen treat for everyone. Explore the world of ice cream in a fun and flavorful way.",
                    ImagePath = "ice_cream_world.jpg"
                },
                new Place
                {
                    Name = "Frozen Drinks Bar",
                    Description = "Cool down with refreshing and creatively crafted frozen drinks at our Frozen Drinks Bar! Our skilled mixologists blend together tropical flavors and icy delights to create the perfect beverages for a hot day in the park. Cheers to relaxation!",
                    ImagePath = "frozen_drinks_bar.jpg"
                },
                new Place
                {
                    Name = "Camel Rides",
                    Description = "Embark on a unique journey through the park with our Camel Rides! Experience the thrill of riding a camel as you explore the sights and sounds of the surroundings. It's a memorable adventure that offers a new perspective on the park.",
                    ImagePath = "camel_rides.jpg"
                },
                new Place
                {
                    Name = "Oasis Pools",
                    Description = "Escape the heat and unwind in our Oasis Pools! With crystal-clear waters and lush surroundings, our pools provide a tranquil setting for relaxation and fun. Whether you're swimming, lounging, or enjoying a tropical drink by the water, our oasis is your retreat.",
                    ImagePath = "oasis_pools.jpg"
                },
                new Place
                {
                    Name = "Star Gazing",
                    Description = "Gaze at the breathtaking night sky with our Star Gazing experience! Away from the city lights, the park offers an ideal location for observing constellations, planets, and celestial wonders. Join us for a guided tour of the cosmos.",
                    ImagePath = "star_gazing.jpg"
                },
                new Place
                {
                    Name = "Night Dune Buggy",
                    Description = "Embark on an exhilarating adventure with our Night Dune Buggy rides! Navigate through the dunes under the moonlit sky and experience the thrill of off-road driving. It's an adrenaline-pumping activity that adds an extra layer of excitement to your park visit.",
                    ImagePath = "night_dune_buggy.jpg"
                }
            };
        }

        public void SetCurrentPlace(string name)
        {
            CurrentPlace = Places.Where(x => x.Name == name).FirstOrDefault();
        }

        [RelayCommand]
        public async Task Help()
        {
            Uri uri = new Uri("https://courses.devs.school");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        [RelayCommand]
        public async Task OpenFlyout()
        {
            Shell.Current.FlyoutIsPresented = true;                     
        }

        [RelayCommand]
        public async Task ShowOffers()
        {
            //await Shell.Current.GoToAsync("//frozenDrinks");

            
            //await Shell.Current.GoToAsync("offersView");

            //await Shell.Current.GoToAsync("//iceCream");
            //await Shell.Current.GoToAsync("details");

            //await Shell.Current.GoToAsync("..");


            await Shell.Current.GoToAsync($"featuredView");
            Shell.Current.FlyoutIsPresented = false;
        }

        [RelayCommand]
        public async Task Search()
        {
            await Shell.Current.GoToAsync("//search");
           //searchView
        }
    }
}

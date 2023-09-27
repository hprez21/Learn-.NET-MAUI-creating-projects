using DevsPark.MVVM.Pages;

namespace DevsPark
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            RegisterRoutes();

            MainPage = serviceProvider.GetRequiredService<AppShell>();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("featuredView", typeof(FeaturedView));
            Routing.RegisterRoute("offersView", typeof(OffersView));
            //Routing.RegisterRoute("searchView", typeof(SearchView));

            //Routing.RegisterRoute("frozenDrinks/details", typeof(FeaturedView));
            //Routing.RegisterRoute("iceCream/details", typeof(OffersView));

        }
    }
}
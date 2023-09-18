using DevsPark.MVVM.Pages;
using DevsPark.MVVM.Pages.DesertMirage.NightAdventures;
using DevsPark.MVVM.Pages.DesertMirage.OasisFun;
using DevsPark.MVVM.Pages.Frozen.IcyTreats;
using DevsPark.MVVM.Pages.Frozen.SnowActivities;
using DevsPark.MVVM.Pages.TropicalParadise.BeachAttractions;
using DevsPark.MVVM.Pages.TropicalParadise.JungleAdventures;
using DevsPark.MVVM.ViewModels;
using Microsoft.Extensions.Logging;

namespace DevsPark
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Kanit-Regular.ttf", "Kanit");
                    fonts.AddFont("Kanit-Bold.ttf", "KanitB");
                    fonts.AddFont("fontello.ttf", "Icons");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<NightDuneBuggy>();
            builder.Services.AddTransient<StarGazing>();
            builder.Services.AddTransient<CamelRides>();
            builder.Services.AddTransient<OasisPools>();
            builder.Services.AddTransient<FrozenDrinksBar>();
            builder.Services.AddTransient<IceCreamWorld>();
            builder.Services.AddTransient<IceSculptures>();
            builder.Services.AddTransient<Snowboarding>();
            builder.Services.AddTransient<SurfLessons>();
            builder.Services.AddTransient<WavePool>();
            builder.Services.AddTransient<AnimalShows>();
            builder.Services.AddTransient<ZipLines>();
            builder.Services.AddTransient<AppShell>();
            builder.Services.AddTransient<AppShellTabs>();
            builder.Services.AddTransient<FeaturedView>();
            builder.Services.AddTransient<OffersView>();
            builder.Services.AddTransient<SearchView>();


            builder.Services.AddTransient<PlacesViewModel>();
            builder.Services.AddTransient<FeaturedViewModel>();
            builder.Services.AddTransient<OffersViewModel>();

            builder.Services.AddSingleton<OffersService>();


            return builder.Build();
        }
    }
}
using DevsPark.MVVM.Pages.DesertMirage.NightAdventures;
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

            builder.Services.AddTransient<PlacesViewModel>();


            return builder.Build();
        }
    }
}
using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.DesertMirage.NightAdventures;

public partial class NightDuneBuggy : ContentPage
{
	public NightDuneBuggy(PlacesViewModel vm)
	{
		InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}
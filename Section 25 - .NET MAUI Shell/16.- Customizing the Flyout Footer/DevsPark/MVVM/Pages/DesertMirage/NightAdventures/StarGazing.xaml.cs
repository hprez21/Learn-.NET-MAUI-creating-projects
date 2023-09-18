using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.DesertMirage.NightAdventures;

public partial class StarGazing : ContentPage
{
	public StarGazing(PlacesViewModel vm)
	{
		InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}
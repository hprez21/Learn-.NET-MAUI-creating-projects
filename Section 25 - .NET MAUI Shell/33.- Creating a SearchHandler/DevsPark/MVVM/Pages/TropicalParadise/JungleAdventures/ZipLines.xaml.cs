using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.TropicalParadise.JungleAdventures;

public partial class ZipLines : ContentPage
{
	public ZipLines(PlacesViewModel vm)
	{
		InitializeComponent();		
		
		vm.SetCurrentPlace(this.GetName());		
		BindingContext = vm;
	}
}
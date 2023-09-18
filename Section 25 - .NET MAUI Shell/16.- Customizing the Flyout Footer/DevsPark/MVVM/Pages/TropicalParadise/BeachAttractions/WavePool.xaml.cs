using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.TropicalParadise.BeachAttractions;

public partial class WavePool : ContentPage
{
	public WavePool(PlacesViewModel vm)
	{
		InitializeComponent();		
		
		vm.SetCurrentPlace(this.GetName());		
		BindingContext = vm;
	}
}
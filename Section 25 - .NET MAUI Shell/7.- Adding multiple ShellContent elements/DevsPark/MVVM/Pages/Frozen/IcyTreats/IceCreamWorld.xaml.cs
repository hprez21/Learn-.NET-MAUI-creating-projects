using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.Frozen.IcyTreats;

public partial class IceCreamWorld : ContentPage
{
	public IceCreamWorld(PlacesViewModel vm)
	{
		InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}
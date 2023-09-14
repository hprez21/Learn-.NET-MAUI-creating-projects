using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.DesertMirage.OasisFun;

public partial class CamelRides : ContentPage
{
	public CamelRides(PlacesViewModel vm)
	{
		InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}
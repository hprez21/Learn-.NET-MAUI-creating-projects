using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.DesertMirage.OasisFun;

public partial class OasisPools : ContentPage
{
	public OasisPools(PlacesViewModel vm)
	{
		InitializeComponent();

        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}
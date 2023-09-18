using DevsPark.Utilities;
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages.Frozen.SnowActivities;

public partial class Snowboarding : ContentPage
{
	public Snowboarding(PlacesViewModel vm)
	{
		InitializeComponent();
        vm.SetCurrentPlace(this.GetName());
        BindingContext = vm;
    }
}
using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages;

public partial class OffersView : ContentPage
{
	public OffersView(OffersViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
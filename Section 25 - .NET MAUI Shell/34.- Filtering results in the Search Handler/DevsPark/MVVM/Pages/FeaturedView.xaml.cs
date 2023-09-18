using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages;

public partial class FeaturedView : ContentPage
{
	public FeaturedView(FeaturedViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
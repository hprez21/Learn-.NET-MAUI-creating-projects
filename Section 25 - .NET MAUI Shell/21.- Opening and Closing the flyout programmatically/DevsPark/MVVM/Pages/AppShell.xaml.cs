using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages;

public partial class AppShell : Shell
{
	public AppShell(PlacesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
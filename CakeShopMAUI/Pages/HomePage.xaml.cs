using CakeShopMAUI.ViewModels;

namespace CakeShopMAUI.Pages;


public partial class HomePage : ContentPage
{
	private	readonly HomeViewModel _homeViewModel;
	public HomePage(HomeViewModel homeViewModel)
	{
		InitializeComponent();
        _homeViewModel = homeViewModel;
		BindingContext = _homeViewModel;
    }
}
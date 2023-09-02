using CakeShopMAUI.ViewModels;

namespace CakeShopMAUI.Pages;

public partial class AllCakePage : ContentPage
{
	private readonly AllCakeViewModel _allCakeViewModel;
	public AllCakePage(AllCakeViewModel allCakeViewModel)
	{
		InitializeComponent();
		_allCakeViewModel = allCakeViewModel;
		BindingContext = _allCakeViewModel;

    }
}
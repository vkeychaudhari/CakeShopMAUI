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

    protected override async void OnAppearing()
    {
        base.OnAppearing();	
		if(_allCakeViewModel.FromSearch)
		{
			await Task.Delay(100);
			sbCake.Focus();
		}
    }

    private void sbCake_TextChanged(object sender, TextChangedEventArgs e)
    {
		if(!string.IsNullOrWhiteSpace(e.OldTextValue)
			&& string.IsNullOrWhiteSpace(e.NewTextValue))
		{
			_allCakeViewModel.SearchCakeCommand.Execute(null);
		}
    }
}
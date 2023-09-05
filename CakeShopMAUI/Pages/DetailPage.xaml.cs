using CakeShopMAUI.ViewModels;

namespace CakeShopMAUI.Pages;

public partial class DetailPage : ContentPage
{
    private readonly DetailPageViewModel _detailPageViewModel;
    public DetailPage(DetailPageViewModel detailPageViewModel)
	{
		InitializeComponent();
		_detailPageViewModel = detailPageViewModel;
		BindingContext = _detailPageViewModel;
	}
}
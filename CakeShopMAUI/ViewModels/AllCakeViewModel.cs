using CakeShopMAUI.Models;
using CakeShopMAUI.Pages;
using CakeShopMAUI.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace CakeShopMAUI.ViewModels
{
    [QueryProperty(nameof(FromSearch),nameof(FromSearch))]
    public partial class AllCakeViewModel : ObservableObject
    {
        public ObservableCollection<Cake> Cakes { get; set; }

        [ObservableProperty]
        private bool _fromSearch;

        [ObservableProperty]
        private bool _searching;

        private readonly CakeService _cakeService;
        public AllCakeViewModel(CakeService cakeService)
        {
            _cakeService = cakeService;
            Cakes = new(_cakeService.GetAllPizzas());
           // bool val = this.FromSearch;   
        }

        [RelayCommand]
        private async Task SearchCake(string serachTerm)
        {
            Cakes.Clear();
            Searching = true;
            await Task.Delay(1000); 
            foreach (var cake in _cakeService.SearchCakes(serachTerm))
            {
                Cakes.Add(cake);
            }
            Searching = false;
        }

        [RelayCommand]
        private async Task GoToDetailPage(Cake cake)
        {
            var parameter = new Dictionary<string, object>
            {
                [nameof(DetailPageViewModel.Cake)] = cake,
            };
            await Shell.Current.GoToAsync(nameof(DetailPage), animate: true, parameter);
        }
    }
}

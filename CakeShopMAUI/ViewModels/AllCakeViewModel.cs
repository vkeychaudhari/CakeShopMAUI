using CakeShopMAUI.Models;
using CakeShopMAUI.Services;
using CommunityToolkit.Mvvm.ComponentModel;
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
            Cakes = new ObservableCollection<Cake>();
            bool val = this.FromSearch;
        }

        private async Task SearchCake(string serachTerm)
        {
            Cakes.Clear();
            foreach (var cake in _cakeService.SearchCakes(serachTerm))
            {
                Cakes.Add(cake);
            }
        }
    }
}

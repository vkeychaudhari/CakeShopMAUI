using CakeShopMAUI.Models;
using CakeShopMAUI.Pages;
using CakeShopMAUI.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShopMAUI.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly CakeService _cakeservice;

        public ObservableCollection<Cake> Cakes { get; set; }
        public HomeViewModel(CakeService cakeService)
        {
            _cakeservice = cakeService;
            Cakes = new(_cakeservice.GetPopularPizzas());
        }

        [RelayCommand]
        private async Task GoToAllCakePage(bool fromsearch)
        {

            //var parameter = new Dictionary<string, object>
            //{
            //    ["FromSearch"] = fromsearch, // Make sure this parameter name matches the property name in AllCakeViewModel
            //};

            var parameter = new Dictionary<string, object>
            {
                [nameof(AllCakeViewModel.FromSearch)] = fromsearch,
            };
            await Shell.Current.GoToAsync(nameof(AllCakePage),animate : true, parameter);
        }
    }
}

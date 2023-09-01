using CakeShopMAUI.Models;
using CakeShopMAUI.Services;
using CommunityToolkit.Mvvm.ComponentModel;
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
    }
}

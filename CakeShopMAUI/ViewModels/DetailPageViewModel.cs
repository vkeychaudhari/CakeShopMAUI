using CakeShopMAUI.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeShopMAUI.ViewModels
{
    [QueryProperty(nameof(Cake), nameof(Cake))]
    public partial class DetailPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private Cake _cake;

        public DetailPageViewModel()
        {
            
        }
    }
}

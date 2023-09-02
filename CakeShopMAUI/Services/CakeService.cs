using CakeShopMAUI.Models;

namespace CakeShopMAUI.Services
{
    public class CakeService
    {
        private readonly static IEnumerable<Cake> _cakes = new List<Cake>
        {
            new Cake
            {
                Name = "Cake 1",
                Image ="cake1img.svg",
                Price = 5
            },
            new Cake
            {
                Name = "Cake 2",
                Image ="cake2img.svg",
                Price = 10
            },
            new Cake
            {
                Name = "Cake 3",
                Image ="cake3img.svg",
                Price = 20
            },
            new Cake
            {
                Name = "Cake 4",
                Image ="cake4img.svg",
                Price = 30
            },
            new Cake
            {
                Name = "Cake 5",
                Image ="cake5img.svg",
                Price = 5
            },
            new Cake
            {
                Name = "Cake 6",
                Image ="cake6img.svg",
                Price = 5
            },
            new Cake
            {
                Name = "Cake 7",
                Image ="cake7img.svg",
                Price = 15
            },
            new Cake
            {
                Name = "Cake 8",
                Image ="cake8img.svg",
                Price = 5
            },
            new Cake
            {
                Name = "Cake 9",
                Image ="cake9img.svg",
                Price = 10
            },
            new Cake
            {
                Name = "Cake 10",
                Image ="cake10img.svg",
                Price = 5
            },
        };

        public IEnumerable<Cake> GetAllPizzas() => _cakes;

        public IEnumerable<Cake> GetPopularPizzas(int count = 6) => _cakes.OrderBy(p=>Guid.NewGuid()).Take(count);

        public IEnumerable<Cake> SearchCakes(string searchTerm) => string.IsNullOrEmpty(searchTerm)?_cakes : _cakes.Where(p=>p.Name.Contains(searchTerm,StringComparison.OrdinalIgnoreCase));
    }
}

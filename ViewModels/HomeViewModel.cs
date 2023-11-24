using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars { get; set; }
    }
}

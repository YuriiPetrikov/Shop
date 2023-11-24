using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars {  get; set; }
        public string carrCategory { get; set; }
    }
}

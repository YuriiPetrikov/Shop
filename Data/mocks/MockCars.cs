using Shop.Data.interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        { 
            get
            {
                return new List<Car>()
                {
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        isFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Ford Fiestsa",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/fiesta.jpg",
                        Price = 11000,
                        isFavourite = false,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/m3.jpg",
                        Price = 65000,
                        isFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        Name = "Mercedes C class",
                        ShortDesc = "Уютный и большой",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/mercedes.jpg",
                        Price = 40000,
                        isFavourite = false,
                        Available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                     new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        isFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономичный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/nissan.jpg",
                        Price = 14000,
                        isFavourite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
                  
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}

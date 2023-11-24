using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый и очень тихий автомобиль компании Tesla",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        isFavourite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Электромобили"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                        new Category { CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (var el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }

                return category;
            }
        }
    }
}
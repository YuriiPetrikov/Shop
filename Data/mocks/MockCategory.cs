using Shop.Data.interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Электромобили", Desc = "Современный вид транспорта"},
                    new Category { CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания"}

                };
            }
        }
    }
}

using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

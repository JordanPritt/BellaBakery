using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBakery.Models
{
    public class MockCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{ CategoryId = 1, CategoryName = "Fruit Pies", Description="Fruit filled pies"},
            new Category{ CategoryId = 2, CategoryName = "Cheese Cakes", Description="Cheesy goodness pies."},
            new Category{ CategoryId = 3, CategoryName = "Seasonal Pies", Description="Season's  greetings via pies."}
        };
    }
}

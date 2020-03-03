using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBakery.Models
{
    public class MockPieRepo : IPieRepo
    {
        private readonly ICategoryRepo _categoryRepo = new MockCategoryRepo();
        public IEnumerable<Pie> AllPies => new List<Pie>
        {
            new Pie{ PieId = 1, Name = "Strawberry Pie", Price = 19.95M, ShortDescription = "Strawberry Goodness", LongDescription = "A delicious sweet and juicy strawberry filled pie, made from locally farmed strarberries.", IsPieOfTheWeek = true, Category = new Category { CategoryId = 1, CategoryName = "Fruit Pies", Description="Fruit filled pies"} },
        };

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie GetPieById(int id)
        {
            return AllPies.FirstOrDefault(p => p.PieId == id);
        }
    }
}

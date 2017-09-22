using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryOnlineShop.Model
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId = 1, CategoryName = "Fruit pies", Description ="All fruit pies"},
                    new Category { CategoryId = 2, CategoryName = "Cheese cakes", Description = "All cheese cakes" },
                    new Category { CategoryId = 3, CategoryName = "Season pies", Description = "All season pies" }
                };
            }
        }
    }
}

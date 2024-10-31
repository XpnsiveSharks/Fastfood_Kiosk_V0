using Fastfood_Kiosk_V0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_V0.Repositories
{
    internal interface ICategoryRepository
    {
        void AddCategory(Category category);
        List<Category> GetAllCategories();
    }
}

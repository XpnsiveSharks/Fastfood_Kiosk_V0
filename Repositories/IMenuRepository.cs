using Fastfood_Kiosk_V0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Fastfood_Kiosk_V0.Repositories
{
    internal interface IMenuRepository
    {
        void AddMenu(ItemMenu menu);
        List<Menu> GetMenuList();
    }
}

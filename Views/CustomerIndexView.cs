using Fastfood_Kiosk_V0.Models;
using Fastfood_Kiosk_V0.ViewModels;
using Fastfood_Kiosk_V0.Views.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views
{
    public partial class CustomerIndexView : Form
    {
        public CustomerIndexView()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            List<Category> categories = categoryViewModel.LoadAllCategories();
            foreach(Category category in categories)
            {
                CategoryUserControl categoryUserControl = new CategoryUserControl
                {
                    CategoryId = category.Category_Id,
                    CategoryName = category.Category_Name,
                    CategoryImage = category.Category_Image
                };
                CategoryFlowLayoutPanel.Controls.Add(categoryUserControl);
            }
        }
    }
}

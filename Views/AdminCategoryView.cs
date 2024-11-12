using Fastfood_Kiosk_V0.Views.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views
{
    public partial class AdminCategoryView : Form
    {
        public AdminCategoryView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminCategoryView_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCategoryListUserControl()
        {
            CategoryListUserControl _categoryListUserControl = new CategoryListUserControl();
            _categoryListUserControl.Dock = DockStyle.Fill;
            AdminCategoryMainPanel.Controls.Clear();
            AdminCategoryMainPanel.Controls.Add(_categoryListUserControl);
        }

        private void CategoryListButton_Click(object sender, EventArgs e)
        {
            LoadCategoryListUserControl();
        }

        private void LoadMenuItemUserControl()
        {
            AddMenuItemUserControl addMenuItemUserControl = new AddMenuItemUserControl();
            addMenuItemUserControl.Dock = DockStyle.Fill;
            AdminCategoryMainPanel.Controls.Clear();
            AdminCategoryMainPanel.Controls.Add(addMenuItemUserControl);
        }

      
        private void MenuItemsListButton_Click(object sender, EventArgs e)
        {
            LoadMenuItemUserControl();
        }

       
        private void AdminCategoryMainPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views.UserControls
{
    public partial class CategoryListUserControl : UserControl
    {
        public CategoryListUserControl()
        {
            InitializeComponent();
        }

        private void LoadAddCategoryUserControl()
        {
            AddCategoryUserControl _addCategoryUserControl = new AddCategoryUserControl();
            _addCategoryUserControl.Dock = DockStyle.Fill;
            CategoryListFlowLayoutPanel.Controls.Clear();
            CategoryListFlowLayoutPanel.Controls.Add( _addCategoryUserControl);
        }
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            LoadAddCategoryUserControl();
        }
    }
}

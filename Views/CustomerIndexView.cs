using Fastfood_Kiosk_V0.Models;
using Fastfood_Kiosk_V0.ViewModels;
using Fastfood_Kiosk_V0.Views.UserControls;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastfood_Kiosk_V0.Views
{
    public partial class CustomerIndexView : Form
    {
        private readonly CategoryViewModel _categoryViewModel;
        public CustomerIndexView()
        {
            InitializeComponent();
            _categoryViewModel = new CategoryViewModel();
            _categoryViewModel.PropertyChanged += CategoryViewModel_PropertyChanged;
            _categoryViewModel.LoadCategories(); 
            UpdateCategoryFlowLayoutPanel();
        }
        private void CategoryViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_categoryViewModel.CategoryControls))
            {
                UpdateCategoryFlowLayoutPanel();
            }
        }

        private void UpdateCategoryFlowLayoutPanel()
        {
            CategoryFlowLayoutPanel.Controls.Clear();
            foreach (var control in _categoryViewModel.CategoryControls)
            {
                CategoryFlowLayoutPanel.Controls.Add(control);
            }
        }
    }
}

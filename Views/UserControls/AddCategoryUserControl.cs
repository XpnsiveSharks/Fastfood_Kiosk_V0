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
    public partial class AddCategoryUserControl : UserControl
    {
        public AddCategoryUserControl()
        {
            InitializeComponent();
        }

       
        private void CancelCategoryButton_Click(object sender, EventArgs e)
        {     
                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove( this );
                }     
        }
    }
}

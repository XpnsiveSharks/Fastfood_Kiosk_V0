using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fastfood_Kiosk_V0.Models
{
    internal class ItemMenu
    {
        public int Menu_Id { get; set; }
        public int Category_Id { get; set; }
        public string Menu_Name { get; set; }
        public double Menu_Price { get; set;}
        public string Description { get; set;}
        public string Menu_Image_File_Path { get; set;}
    }
}

using Fastfood_Kiosk_V0.Models;
using Fastfood_Kiosk_V0.Repositories;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Fastfood_Kiosk_V0.ViewModels
{
    internal class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _categoryId;
        public int MyProperty { get; set; }
        //baka makalimutan mo may gagawin ka dito teh
    }
}

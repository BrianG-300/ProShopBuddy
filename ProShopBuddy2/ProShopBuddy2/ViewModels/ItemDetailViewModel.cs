using System;
using ProShopBuddy;
using ProShopBuddy2.Models;

namespace ProShopBuddy2.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Players Item { get; set; }
        public ItemDetailViewModel(Players item = null)
        {
            //Title = item?.Text;
            Item = item;
        }
    }
}

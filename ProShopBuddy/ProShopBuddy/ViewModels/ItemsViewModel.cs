using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ProShopBuddy.Models;
using ProShopBuddy.Views;
using MvvmCross.Core.ViewModels;

namespace ProShopBuddy.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ItemsViewModel()
        {
        }

        int selectMode;

        public void Init(int mode)
        {
            selectMode = mode;
        }

        public void loadPage(Players player)
        {
            ShowViewModel<ItemsViewModel>(new { id = player._ID, mode = selectMode });
        }

        public void GoTo_DeleteCommand(Players deletePlayer)
        {
            App.Database.DeletePlayerAsync(deletePlayer);
        }

        public void GoTo_AddCommand()
        {
            ShowViewModel<ItemsViewModel>(new { mode = 2 });
        }

        public void GoTo_LoadCommand(Players p)
        {
            ShowViewModel<ItemsViewModel>(new { mode = 0, id = p._ID });
        }

        public void GoTo_ECommand(Players p)
        {
            ShowViewModel<ItemsViewModel>(new { mode = 1, id = p._ID });
        }

    }
}

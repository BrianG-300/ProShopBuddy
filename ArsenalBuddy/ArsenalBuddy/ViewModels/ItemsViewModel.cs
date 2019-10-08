using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ArsenalBuddy.Models;
using ArsenalBuddy.Views;
using System.Collections.Generic;

namespace ArsenalBuddy.ViewModels
{
    public class ItemsViewModel :  BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private List<BowlingBalls> _ballCollection;
        public List<BowlingBalls> BALLCollection
        {
            get => _ballCollection ?? (_ballCollection = new List<BowlingBalls>());
            set
            {
                _ballCollection = value;
                RaisePropertyChanged(() => BALLCollection);
            }
        }

        //public void GoTo_AddCommand()
        //{
        //    base.ShowViewModel<ItemDetailViewModel>(new { mode = 2 });
        //}

        //public void GoTo_LoadCommand(BowlingBalls p)
        //{
        //    base.ShowViewModel<ItemDetailViewModel>(new { mode = 0, id = p._ID });
        //}

        //public void GoTo_ECommand(BowlingBalls p)
        //{
        //    base.ShowViewModel<ItemDetailViewModel>(new { mode = 1, id = p._ID });
        //}
    }
}
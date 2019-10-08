using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ArsenalBuddy.Models;
using ArsenalBuddy.Views;
using ArsenalBuddy.ViewModels;

namespace ArsenalBuddy.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);

            ItemsListView.ItemsSource = await App.Database.GetBallsAsync();

        }

        public async void OnDelete(object sender, EventArgs e)
        {
            ItemsViewModel vm = this.BindingContext as ItemsViewModel;

            var mi = ((MenuItem)sender);
            BowlingBalls p = mi.CommandParameter as BowlingBalls;
            var x = await DisplayAlert("Deleting", "Deleting " + p.MODELNAME + "'s details", "OK", "Cancel");
            if (x)
            {
                //vm.GoTo_DeleteCommand(p);
                await Task.Delay(60);
                ItemsListView.ItemsSource = await App.Database.GetBallsAsync();
            }
        }

        public async void OnLoad(object sender, EventArgs e)
        {
            ItemsViewModel vm = this.BindingContext as ItemsViewModel;

            var mi = ((MenuItem)sender);
            BowlingBalls p = mi.CommandParameter as BowlingBalls;
            var x = await DisplayAlert("Loading", "Loading " + p.MODELNAME + "'s details", "OK", "Cancel");
            if (x)
            {
                //vm.GoTo_LoadCommand(p);
                ItemsListView.ItemsSource = await App.Database.GetBallsAsync();
            }
        }

        public async void OnEdit(object sender, EventArgs e)
        {
            ItemsViewModel vm = this.BindingContext as ItemsViewModel;

            var mi = ((MenuItem)sender);
            BowlingBalls p = mi.CommandParameter as BowlingBalls;
            var x = await DisplayAlert("Editing", "Editing " + p.MODELNAME + "'s details", "OK", "Cancel");
            if (x)
            {
                //vm.GoTo_ECommand(p);
                ItemsListView.ItemsSource = await App.Database.GetBallsAsync();
            }
        }
    }
}
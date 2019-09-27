using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using ProShopBuddy.ViewModels;

namespace ProShopBuddy.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsViewModel viewModel;
        Image newImage;

        public ItemsPage()
        {
            InitializeComponent();
            viewModel = this.BindingContext as ItemsViewModel;

        }

        void AddPlayer_Clicked(object sender, System.EventArgs e)
        {
            //viewModel.GoTo_AddCommand();
            Navigation.PushModalAsync(new NavigationPage(new AddItemDetailPage()));

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (PlayerListView != null)
            {
                PlayerListView.ItemsSource = await App.Database.GetPlayersAsync();
            }
        }

        private void PlayerListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Players p = e.SelectedItem as Players;
                //ItemsViewModel vm = this.BindingContext as ItemsViewModel;
            }
        }

        public async void OnDelete(object sender, EventArgs e)
        {
            //ItemsViewModel vm = this.BindingContext as ItemsViewModel;

            var mi = ((MenuItem)sender);
            Players p = mi.CommandParameter as Players;
            var x = await DisplayAlert("Deleting", "Deleting " + p.TEXTNAME + "'s details", "OK", "Cancel");
            if (x)
            {
                viewModel.GoTo_DeleteCommand(p);
                await Task.Delay(60);
                PlayerListView.ItemsSource = await App.Database.GetPlayersAsync();
            }
        }

        public async void OnLoad(object sender, EventArgs e)
        {
           // ItemsViewModel vm = this.BindingContext as ItemsViewModel;

            var mi = ((MenuItem)sender);
            Players p = mi.CommandParameter as Players;
            var x = await DisplayAlert("Loading", "Loading " + p.TEXTNAME + "'s details", "OK", "Cancel");
            if (x)
            {
                //viewModel.GoTo_LoadCommand(p);
                PlayerListView.ItemsSource = await App.Database.GetPlayersAsync();
            }
        }

        public async void OnEdit(object sender, EventArgs e)
        {
           // ItemsViewModel vm = this.BindingContext as ItemsViewModel;

            var mi = ((MenuItem)sender);
            Players p = mi.CommandParameter as Players;
            var x = await DisplayAlert("Editing", "Editing " + p.TEXTNAME + "'s details", "OK", "Cancel");
            if (x)
            {
                //viewModel.GoTo_ECommand(p);
                PlayerListView.ItemsSource = await App.Database.GetPlayersAsync();
            }
        }
    }
}

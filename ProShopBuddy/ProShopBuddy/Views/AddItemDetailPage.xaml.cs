using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ProShopBuddy.Models;
using ProShopBuddy.ViewModels;

namespace ProShopBuddy.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AddItemDetailPage : ContentPage
    {
        AddItemDetailViewModel viewModel;

        public AddItemDetailPage()
        {
            InitializeComponent();
            viewModel = new AddItemDetailViewModel();
            //var image = this.FindByName<Image>("DrillImage");
            //image.Source = ImageSource.FromResource("BG300ProShop.Core.Drill_Sheet2.png");
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            bool x = await DisplayAlert("Save?", "Save details for: " + viewModel.SelectedPlayer.TEXTNAME, "OK", "Cancel");

            if (x)
            {
                viewModel.SaveButtonAction();

                await App.Database.SavePlayerAsync(viewModel.SelectedPlayer);

            }
        }

        void OnRefClicked(object sender, EventArgs e)
        {
            viewModel.GoTo_RefCommand();
        }
    }
}
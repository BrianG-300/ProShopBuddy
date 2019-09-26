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
    public partial class EditItemDetailPage : ContentPage
    {
        EditItemDetailViewModel viewModel;

        public EditItemDetailPage(EditItemDetailViewModel viewModel)
        {
            InitializeComponent();

            viewModel = this.BindingContext as EditItemDetailViewModel;

        }

        public EditItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

           // viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        

        var image = this.FindByName<Image>("DrillImage");
        image.Source = ImageSource.FromResource("BG300ProShop.Core.Drill_Sheet2.png");
        }

    async void OnSaveClicked(object sender, EventArgs e)
    {

        bool x = await DisplayAlert("Save?", "Save details for: " + viewModel.SelectedPlayer.TEXTNAME, "OK", "Cancel");

        if (x)
        {
                viewModel.SaveButtonAction();
        }
    }

    void OnRefClicked(object sender, EventArgs e)
    {
            viewModel.GoTo_RefCommand();
    }
}
}
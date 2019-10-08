using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ArsenalBuddy.Models;

namespace ArsenalBuddy.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }
        BowlingBalls SelectedBall;

        public NewItemPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public async void Init(int id)
        {
            SelectedBall = new BowlingBalls();

        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            // MessagingCenter.Send(this, "AddItem", Item);
            await App.Database.SaveBallAsync(SelectedBall);

            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
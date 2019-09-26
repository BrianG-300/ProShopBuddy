using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProShopBuddy.Services;
using ProShopBuddy.Views;

namespace ProShopBuddy
{
    public partial class App : Application
    {
        static PlayerDatabase database;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }
        public static PlayerDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PlayerDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("Players.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

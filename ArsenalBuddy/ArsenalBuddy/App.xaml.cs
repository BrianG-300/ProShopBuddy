using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ArsenalBuddy.Services;
using ArsenalBuddy.Views;

namespace ArsenalBuddy
{
    public partial class App : Application
    {
        static BallsDatabase database;

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        public static BallsDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new BallsDatabase(DependencyService.Get<LocalFileHelper>().GetLocalFilePath("Bowling_Balls.db3"));
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

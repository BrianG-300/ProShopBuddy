using System;
using System.Windows.Input;
using MvvmCross.Navigation;
using Xamarin.Forms;

namespace ProShopBuddy.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }

        private readonly IMvxNavigationService _navigationService;

        public AboutViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
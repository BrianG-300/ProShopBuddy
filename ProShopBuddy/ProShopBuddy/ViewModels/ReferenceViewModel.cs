using System;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ProShopBuddy.ViewModels
{
    public class ReferenceViewModel : BaseViewModel
    {
        public ReferenceViewModel()
        {
        }

        private readonly IMvxNavigationService _navigationService;

        public ReferenceViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

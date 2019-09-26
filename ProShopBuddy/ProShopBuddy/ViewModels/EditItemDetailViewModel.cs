using System;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using ProShopBuddy.Models;

namespace ProShopBuddy.ViewModels
{
    public class EditItemDetailViewModel : BaseViewModel
    {
        public EditItemDetailViewModel()
        {
        }

        private readonly IMvxNavigationService _navigationService;

        public EditItemDetailViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public class DetailParameters
        {
            public int id
            {
                get;
                set;
            }

            public int mode
            {
                get;
                set;
            }
        }

        public async void Init(DetailParameters parameters)
        {
            EntryEnabled = false;
            switch (parameters.mode)
            {
                case 0:
                    //viewing data
                    EntryEnabled = false;
                    break;
                case 1:
                    //Editing data
                    EntryEnabled = true;
                    break;
                case 2:
                    //Add data
                    EntryEnabled = true;
                    break;
                default:
                    break;
            }

            if (parameters.mode != 2)
            {
                //Get Players
                SelectedPlayer = await App.Database.GetPlayerAsync(parameters.id);
            }
            else
            {
                //Add Players
                SelectedPlayer = new Players();
            }
        }

        public void GoTo_RefCommand()
        {
            //base.ShowViewModel<ReferencesViewModel>();
            _navigationService.Navigate<ReferenceViewModel>();
        }

        private Players _selectedPlayer;
        public Players SelectedPlayer
        {
            get
            {
                return _selectedPlayer;
            }
            set
            {
                _selectedPlayer = value;
                RaisePropertyChanged(() => SelectedPlayer);
            }
        }

        private bool _entryEnabled;
        public bool EntryEnabled
        {
            get
            {
                return _entryEnabled;
            }
            set
            {
                _entryEnabled = value;
                RaisePropertyChanged(() => EntryEnabled);
            }

        }

        private string _name = "Load Details";
        public string Name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }

        public async void SaveButtonAction()
        {
            await App.Database.SavePlayerAsync(SelectedPlayer);

        }

        public override void Prepare(Players parameter)
        {
            throw new NotImplementedException();
        }
    }
}

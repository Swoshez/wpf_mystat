using ContactListApp.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.ViewModel
{
    class SecondViewModel : ViewModelBase
    {
        public INavigationService NavigationService { get; }

        public SecondViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        private RelayCommand goBackCommand;
        public RelayCommand GoBackCommand
        {
            get => goBackCommand ?? (goBackCommand = new RelayCommand(
                () =>
                {
                    NavigationService.Navigate("Main");
                }
            ));
        }
    }
}

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
    class MainViewModel : ViewModelBase
    {
        private string text;
        public string Text { get => text; set => Set(ref text, value); }

        public INavigationService NavigationService { get; }
        public ITestService TestService { get; }

        public MainViewModel(INavigationService navigationService, ITestService testService)
        {
            NavigationService = navigationService;
            TestService = testService;

            Text = TestService.Test();
        }

        private RelayCommand toSecondViewCommand;
        public RelayCommand ToSecondViewCommand
        {
            get => toSecondViewCommand ?? (toSecondViewCommand = new RelayCommand(
                () => 
                {
                    NavigationService.Navigate("Second");
                }
            ));
        }
    }
}

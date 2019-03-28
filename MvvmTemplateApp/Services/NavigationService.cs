using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace ContactListApp.Services
{
    class NavigationService : INavigationService
    {
        Dictionary<string, ViewModelBase> pages = new Dictionary<string, ViewModelBase>();

        public void AddPage(string name, ViewModelBase viewModel)
        {
            pages.Add(name, viewModel);
        }

        public void Navigate(string name)
        {
            Messenger.Default.Send(pages[name]);
        }
    }
}

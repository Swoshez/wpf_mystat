using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp.Services
{
    interface INavigationService
    {
        void Navigate(string name);
        void AddPage(string name, ViewModelBase viewModel);
    }
}

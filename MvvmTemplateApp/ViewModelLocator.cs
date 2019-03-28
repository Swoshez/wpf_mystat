using Autofac;
using ContactListApp.Services;
using ContactListApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp
{
    class ViewModelLocator
    {
        public AppViewModel AppViewModel { get; set; }
        public MainViewModel MainViewModel { get; set; }
        public SecondViewModel SecondViewModel { get; set; }

        public INavigationService NavigationService { get; set; }

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AppViewModel>();
            builder.RegisterType<MainViewModel>();
            builder.RegisterType<SecondViewModel>();
            builder.RegisterType<NavigationService>().As<INavigationService>().InstancePerLifetimeScope();
            builder.RegisterType<TestServiceOne>().As<ITestService>().InstancePerLifetimeScope();
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                AppViewModel = scope.Resolve<AppViewModel>();
                MainViewModel = scope.Resolve<MainViewModel>();
                SecondViewModel = scope.Resolve<SecondViewModel>();

                NavigationService = scope.Resolve<INavigationService>();
            };

            NavigationService.AddPage("Main", MainViewModel);
            NavigationService.AddPage("Second", SecondViewModel);

            NavigationService.Navigate("Main");
        }
    }
}

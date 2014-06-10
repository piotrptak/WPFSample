using Microsoft.Practices.Unity;
using Pptak.WPFSample.DomainServices;
using Pptak.WPFSample.Stubs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFSample.ViewModels;

namespace WPFSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRepositoryLocator, StubRepositoryLocator>();
            container.RegisterType<IMainViewModel, MainViewModel>();
            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();

        }

    }
}

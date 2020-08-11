using Autofac;
using FriendOrganizer.Ui.Data;
using FriendOrganizer.Ui.Startup;
using FriendOrganizer.Ui.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FriendOrganizer.Ui
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //
            // replace the below with the bootstrapper logic which creates a container using autofac
            //
            //var mainWindow = new MainWindow(
            //                       new MainViewModel(
            //                        new FriendDataService()));


            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();


            var mainWindow = container.Resolve<MainWindow>();
            mainWindow.Show();

        }
    }
}

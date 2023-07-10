using KabuTalk.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KabuTalk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            var mainView = App.Current.Services.GetService<MainWindow>();
            mainView.Show();
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }


        private static IServiceProvider ConfigureServices()
        {
            //Service
            var services = new ServiceCollection();

            services.AddSingleton<ITestService,TestService>(); // 이 테스트서비스를 인터페이스테스트서비스로 주입해주겠다

            //Views
            services.AddSingleton<MainWindow> ();

            return services.BuildServiceProvider();
        }
    }
}

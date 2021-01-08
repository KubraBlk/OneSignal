using Com.OneSignal;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinIceApp.Services;
using XamarinIceApp.Views;

namespace XamarinIceApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            OneSignal.Current.StartInit("440a54e9-42ec-41d9-9593-d4895de4278f")
            .EndInit();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();


        }
        private void ConfigureOneSignal()
        {
            OneSignal.Current.StartInit("440a54e9-42ec-41d9-9593-d4895de4278f")
                .HandleNotificationReceived((result) =>
                {

                })
                .HandleNotificationOpened((notification) =>
                {

                })
                .EndInit();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

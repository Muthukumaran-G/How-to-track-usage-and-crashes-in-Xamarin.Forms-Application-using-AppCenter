using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCenterTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            AppCenter.Start("android=389520bb-8081-4d7a-9794-8e5f0ca3f2a8;" +
                  "uwp=9f362fec-af4c-4391-a007-75ee5e2076c7;" +
                  "ios=e0cf9666-af05-46d5-806a-92cfb277e89e",
                  typeof(Analytics), typeof(Crashes));
            MainPage = new MainPage();
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

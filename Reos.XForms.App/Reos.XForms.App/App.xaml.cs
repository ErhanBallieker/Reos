using System;
using Reos.XForms.App.Helpers;
using Reos.XForms.App.Views;
using Xamarin.Forms;

namespace Reos.XForms.App
{
    public partial class App : Application, ILoginHelper
    {
        //test check..
        public App()
        {
            InitializeComponent();
            instance = this;

            var userLoggedIn = Properties.ContainsKey("UserLoggedIn") ? (bool)Properties["UserLoggedIn"] : false;

            if (!userLoggedIn)
                MainPage = new LoginPage(this);
            else
                MainPage = new RootPage();
        }

        static App instance;

        public static App Instance
        {
            get { return instance; }
        }

        public void ShowRootPage()
        {
            MainPage = new RootPage();
        }

        public void SignOut()
        {
            App.Current.Properties["UserLoggedIn"] = false;
            MainPage = new LoginPage(this);
        }

        #region App Lifcycles..

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #endregion
    }
}

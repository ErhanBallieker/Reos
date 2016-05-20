using Reos.XForms.App.Helpers;
using System;

using Xamarin.Forms;

namespace Reos.XForms.App.Views
{
    public partial class LoginPage : ContentPage
    {
        ILoginHelper _loginHelper;

        public LoginPage(ILoginHelper loginHelper)
        {
            InitializeComponent();

            _loginHelper = loginHelper;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void Login_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName.Text) || string.IsNullOrEmpty(password.Text))
            {
                await DisplayAlert("Kullanıcı Bulunamadı", "Kullanıcı ve Şifrenizi kontrol edin.", "Tamam");
            }
            else
            {
                App.Current.Properties["UserLoggedIn"] = true;
                _loginHelper.ShowRootPage();
            }
        }

        public void Google_Clicked(object sender, EventArgs e)
        {
            App.Current.Properties["UserLoggedIn"] = true;
            _loginHelper.ShowRootPage();
        }

        public void Office_Clicked(object sender, EventArgs e)
        {
            App.Current.Properties["UserLoggedIn"] = true;
            _loginHelper.ShowRootPage();
        }

        public async void ForgotPassword_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Şifremi Unuttum", "Şifreniz E-Posta adresinize gönderildi.", "Tamam");
        }
    }
}

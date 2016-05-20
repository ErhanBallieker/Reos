using ImageCircle.Forms.Plugin.Abstractions;
using Reos.XForms.App.ViewModels;
using Xamarin.Forms;

namespace Reos.XForms.App.Views
{
    public partial class LeftMenuPage : ContentPage
    {
        public ListView MenuListView { get { return menuListView; } }

        public LeftMenuPage()
        {
            InitializeComponent();

            var menuPageViewModel = new MainMenuViewModel();

            menuListView.ItemsSource = menuPageViewModel.MenuItemList;
        }
    }
}

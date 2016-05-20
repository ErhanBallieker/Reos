using Reos.App.Model.Menu;
using System;
using Xamarin.Forms;

namespace Reos.XForms.App.Views
{
    public partial class RootPage : MasterDetailPage
    {
        public LeftMenuPage masterPage;
        public RootPage()
        {
            InitializeComponent();

            InitializePages();
            
            masterPage.MenuListView.ItemSelected += MenuListView_ItemSelected;
        }

        private void InitializePages()
        {
            masterPage = new LeftMenuPage();

            Master = masterPage;
            Detail = new NavigationPage(new DashboardPage());
        }

        private void MenuListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as MainMenuItem;

            menu?.TargetAction?.Invoke();

            if (menu != null && menu.TargetAction == null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(menu.TargetPage));
                masterPage.MenuListView.SelectedItem = null;
                IsPresented = false;
            }
            
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            masterPage.MenuListView.ItemSelected -= MenuListView_ItemSelected;
        }
    }
}

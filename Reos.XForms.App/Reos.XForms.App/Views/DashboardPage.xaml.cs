using Reos.XForms.App.ViewModels;
using System.Linq;
using Xamarin.Forms;
using System;
using static Reos.XForms.App.DashboardItemTemplate;

namespace Reos.XForms.App.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {

            InitializeComponent();

            var dashboardViewModel = new DashboardViewModel();

            //BindingContext = dashboardViewModel.MenuItemList;

            var scrollView = new ScrollView();

            var dashboard = new Grid()
            {
                ColumnSpacing = 0,
                RowSpacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            for (int i = 0; i < 4; i++)
            {
                dashboard.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
             }


            for (int i = 0; i < 3; i++)
            {
                dashboard.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }

            var squares = dashboardViewModel.MenuItemList;

            foreach (var item in squares)
            {
                var widget = new DashboardItemTemplate(item);
                widget.Tapped += (object sender, WidgetTappedEventArgs e) =>
                {
                    var page = Activator.CreateInstance(e.Page) as Page;
                    Navigation.PushAsync(page);
                };
                dashboard.Children.Add(widget, item.Column, item.Row);
            }

            scrollView.Content = dashboard;

            Content = scrollView;
        }
    }
}

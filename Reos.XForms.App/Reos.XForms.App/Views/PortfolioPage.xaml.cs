using Reos.App.Model.Portfolio;
using Reos.XForms.App.ViewModels;

using Xamarin.Forms;

namespace Reos.XForms.App.Views
{
    public partial class PortfolioPage : ContentPage
    {
        public PortfolioPage()
        {
            InitializeComponent();

            var portfolioViewModel = new PortfolioViewModel();

            portfolioListView.ItemsSource = portfolioViewModel.PortfolioList;
        }

        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPortfolio = e.SelectedItem as Portfolio;

            if (selectedPortfolio != null)
            {
                portfolioListView.SelectedItem = null;
                await Navigation.PushAsync(new PortfolioDetailPage(selectedPortfolio));
            }
        }
    }
}

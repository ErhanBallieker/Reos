using Reos.App.Model.Portfolio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Reos.XForms.App.Views
{
    public partial class PortfolioDetailPage : ContentPage
    {
        public PortfolioDetailPage(Portfolio portfolio)
        {
            InitializeComponent();

            BindingContext = portfolio;
        }
    }
}

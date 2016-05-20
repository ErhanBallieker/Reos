using Reos.App.Model.Menu;
using Reos.App.Model.User;
using Reos.XForms.App.Views;
using System.Collections.Generic;

namespace Reos.XForms.App.ViewModels
{
    public class MainMenuViewModel
    {
        public MainMenuViewModel()
        {
            MenuItemList = GetMenuItemList();
            LoggedInUser = GetLoggedInUser();
        }

        public User LoggedInUser { get; set; }

        public MainMenuItem SelectedMenuItem { get; set; }

        public IList<MainMenuItem> MenuItemList { get; set; }

        public User GetLoggedInUser()
        {
            return new User
            {
                Name = "Murat",
                LastName = "Yılmaz",
                Email = "murat.yilmaz@anahtarteknoloji.com",
                ProfilePictureUrl = "nomac.png"
            };
        }

        public IList<MainMenuItem> GetMenuItemList()
        {
            var list = new List<MainMenuItem>();

            list.Add(new MainMenuItem
            {
                Title = "Ana Sayfa",
                IconSource = "homapageicon.png",
                TargetPage = typeof(DashboardPage),
            });

            list.Add(new MainMenuItem
            {
                Title = "Portföylerim",
                IconSource = "homapageicon.png",
                TargetPage = typeof(PortfolioPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Müşterilerim",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyClientsPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Ajandam",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyCalendarPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Görüşme Notlarım",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyInterviewsPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Görevlerim",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyTasksPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Gayrimenkul Talepler",
                IconSource = "homapageicon.png",
                TargetPage = typeof(RealEstateRequestsPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Raporlar",
                IconSource = "homapageicon.png",
                TargetPage = typeof(ReportsPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Duyuru / Haber",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyNewsPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Ayarlar",
                IconSource = "homapageicon.png",
                TargetPage = typeof(SettingsPage)
            });

            list.Add(new MainMenuItem
            {
                Title = "Çıkış",
                IconSource = "homapageicon.png",
                TargetPage = null,
                TargetAction = () => { App.Instance.SignOut(); }
            });

            return list;
        }
    }
}

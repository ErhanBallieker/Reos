using Reos.App.Model.Menu;
using Reos.XForms.App.Views;
using System.Collections.Generic;

namespace Reos.XForms.App.ViewModels
{
    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            MenuItemList = GetMenuItemList();
        }

        public MainMenuItem SelectedMenuItem { get; set; }

        public IList<MainMenuItem> MenuItemList { get; set; }

        private IList<MainMenuItem> GetMenuItemList()
        {
            var list = new List<MainMenuItem>();

            list.Add(new MainMenuItem
            {
                Title = "Portföylerim",
                IconSource = "homapageicon.png",
                TargetPage = typeof(PortfolioPage),
                ItemCount = 148,
                Row = 0,
                Column = 0
            });

            list.Add(new MainMenuItem
            {
                Title = "Entegrasyon",
                IconSource = "homapageicon.png",
                TargetPage = typeof(EntegrationPage),
                Row = 0,
                Column = 1
            });

            list.Add(new MainMenuItem
            {
                Title = "Cooperation Referral",
                IconSource = "homapageicon.png",
                TargetPage = typeof(CooperationReferralPage),
                Row = 0,
                Column = 2
            });

            list.Add(new MainMenuItem
            {
                Title = "Müşterilerim",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyClientsPage),
                Row = 1,
                Column = 0,
                ItemCount = 148
            });

            list.Add(new MainMenuItem
            {
                Title = "Talepler",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyTasksPage),
                Row = 1,
                Column = 1,
                ItemCount = 148
            });

            list.Add(new MainMenuItem
            {
                Title = "Eşleşenler",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MatchedItemsPage),
                Row = 1,
                Column = 2,
                ItemCount = 148
            });

            list.Add(new MainMenuItem
            {
                Title = "Görüşmeler",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyInterviewsPage),
                Row = 2,
                Column = 0
            });

            list.Add(new MainMenuItem
            {
                Title = "Görevler",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyTasksPage),
                Row = 2,
                Column = 1,
                ItemCount = 148
            });

            list.Add(new MainMenuItem
            {
                Title = "Ajandam",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyCalendarPage),
                Row = 2,
                Column = 2,
                ItemCount = 148
            });

            list.Add(new MainMenuItem
            {
                Title = "Raporlar",
                IconSource = "homapageicon.png",
                TargetPage = typeof(ReportsPage),
                Row = 3,
                Column = 0,
            });

            list.Add(new MainMenuItem
            {
                Title = "Haberler",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyNewsPage),
                Row = 3,
                Column = 1,
                ItemCount = 148
            });

            list.Add(new MainMenuItem
            {
                Title = "Mesajlar",
                IconSource = "homapageicon.png",
                TargetPage = typeof(MyMessagesPage),
                Row = 3,
                Column = 2,
                ItemCount = 148
            });

            list.Add(new MainMenuItem
            {
                Title = "Destek",
                IconSource = "homapageicon.png",
                TargetPage = typeof(SupportPage),
                Row = 4,
                Column = 0
            });

            list.Add(new MainMenuItem
            {
                Title = "Ayarlar",
                IconSource = "homapageicon.png",
                TargetPage = typeof(SettingsPage),
                Row = 4,
                Column = 1
            });

            return list;
        }
    }
}

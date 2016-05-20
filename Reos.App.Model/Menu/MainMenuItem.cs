using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reos.App.Model.Menu
{
    public class MainMenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetPage { get; set; }

        public Action TargetAction { get; set; }

        #region Dashboard Properties

        public int Column { get; set; }

        public int Row { get; set; }

        public string BackgroundImage { get; set; }

        public string BackgrounColor { get; set; }

        public int ItemCount { get; set; }

        #endregion
    }
}

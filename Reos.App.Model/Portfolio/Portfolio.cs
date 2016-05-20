using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reos.App.Model.Portfolio
{
    public class Portfolio
    {
        public Portfolio()
        {

        }

        public string Title { get; set; }

        public string ShortAddress { get; set; }

        public string PriceFormatted { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
    }
}

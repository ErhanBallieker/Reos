using Reos.App.Model.Portfolio;
using System.Collections.Generic;

namespace Reos.XForms.App.ViewModels
{
    public class PortfolioViewModel
    {
        public PortfolioViewModel()
        {
            GetPortfolioList();
        }

        private IList<Portfolio> portfolioList;

        public IList<Portfolio> PortfolioList { get; set; }

        public void GetPortfolioList()
        {
            portfolioList = new List<Portfolio>();

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."

            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            portfolioList.Add(new Portfolio
            {
                ImageUrl = "portfoliImg.jpg",
                PriceFormatted = "1200 TL.",
                ShortAddress = "İstanbul > Şişli",
                Title = "Müthiş Fırsat Geniş Ailelere Aracısız Lüks Bina",
                Description = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur."
            });

            PortfolioList = portfolioList;
        }
    }
}

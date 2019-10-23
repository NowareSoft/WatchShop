using MvvmHelpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WatchShop.XF.Models;

namespace WatchShop.XF.ViewModels
{
    public class MainViewModel : ObservableObject
    {

        public IList<Watch> Watches { get; set; }

        public MainViewModel()
        {
            Watches = new ObservableCollection<Watch>()
            {
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "BellRoss",
                    Price = 360m,
                    Title = @"Bell & Ross"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "Rado",
                    Price = 480m,
                    Title = @"Rado"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "Heritage",
                    Price = 650m,
                    Title = @"Heritage 1959"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "RoseGold",
                    Price = 550m,
                    Title = @"Rose Gold"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "NavyBlue",
                    Price = 860m,
                    Title = @"Navy Blue"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "AlphaSilver",
                    Price = 240m,
                    Title = @"Alpha Silver"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "Enticer",
                    Price = 400m,
                    Title = @"Enticer"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Image = "TitanEdge",
                    Price = 900m,
                    Title = @"TitanEdge"
                },
            };


        }
    }
}

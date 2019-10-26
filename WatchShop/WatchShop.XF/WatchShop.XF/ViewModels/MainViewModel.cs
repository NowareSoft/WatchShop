using MvvmHelpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using WatchShop.XF.Models;
using Xamarin.Forms;

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
                    Price = 360m,
                    Title = @"Bell & Ross",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "BellRoss.png"
                        },
                        new ImageWatch
                        {
                            Source = "BellRoss.png"
                        },
                        new ImageWatch
                        {
                            Source = "BellRoss.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Price = 480m,
                    Title = @"Rado",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "Rado.png"
                        },
                        new ImageWatch
                        {
                            Source = "Rado.png"
                        },
                        new ImageWatch
                        {
                            Source = "Rado.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Price = 650m,
                    Title = @"Heritage 1959",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "Heritage.png"
                        },
                        new ImageWatch
                        {
                            Source = "Heritage.png"
                        },
                        new ImageWatch
                        {
                            Source = "Heritage.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Price = 550m,
                    Title = @"Rose Gold",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "RoseGold.png"
                        },
                        new ImageWatch
                        {
                            Source = "RoseGold.png"
                        },
                        new ImageWatch
                        {
                            Source = "RoseGold.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Price = 860m,
                    Title = @"Navy Blue",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "NavyBlue.png"
                        },
                        new ImageWatch
                        {
                            Source = "NavyBlue.png"
                        },
                        new ImageWatch
                        {
                            Source = "NavyBlue.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Price = 240m,
                    Title = @"Alpha Silver",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "AlphaSilver.png"
                        },
                        new ImageWatch
                        {
                            Source = "AlphaSilver.png"
                        },
                        new ImageWatch
                        {
                            Source = "AlphaSilver.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Price = 400m,
                    Title = @"Enticer",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "Enticer.png"
                        },
                        new ImageWatch
                        {
                            Source = "Enticer.png"
                        },
                        new ImageWatch
                        {
                            Source = "Enticer.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
                new Watch
                {
                    Brand = "Ambassador",
                    Price = 900m,
                    Title = @"TitanEdge",
                    Case = "40mm acero inoxidable pulido",
                    Images = new List<ImageWatch>
                    {
                        new ImageWatch
                        {
                            Source = "TitanEdge.png"
                        },
                        new ImageWatch
                        {
                            Source = "TitanEdge.png"
                        },
                        new ImageWatch
                        {
                            Source = "TitanEdge.png"
                        },
                    },
                    Movement = "Movimiento de Cuarzo Japonés"
                },
            };
        }
    }
}

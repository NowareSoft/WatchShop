using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using WatchShop.XF.Views;
using Xamarin.Forms;

namespace WatchShop.XF.Models
{
    public class Watch : ObservableObject
    {
        private string _title;
        private string _brand;
        private decimal _price;
        private string _case;
        private string _movement;
        private List<ImageWatch> _images;

        public ICommand DetailsCommand { get; }

        public string Title 
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string Brand
        {
            get => _brand;
            set => SetProperty(ref _brand, value);
        }

        public decimal Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }

        public string Case
        {
            get => _case;
            set => SetProperty(ref _case, value);
        }

        public string Movement
        {
            get => _movement;
            set => SetProperty(ref _movement, value);
        }

        public List<ImageWatch> Images
        {
            get => _images;
            set => SetProperty(ref _images, value);
        }

        public string PriceString => $"${Price.ToString()}";

        public string BrandUp => _brand.ToUpper();

        public string FirstImage => _images.First().Source;

        public Watch()
        {
            DetailsCommand = new Command(async () => await DetailsAsync());
        }

        private async Task DetailsAsync()
        {
            await App.Current.MainPage.Navigation.PushAsync(new WatchDetailsPage(this));
        }
    }
}

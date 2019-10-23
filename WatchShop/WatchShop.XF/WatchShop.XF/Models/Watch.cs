using MvvmHelpers;

namespace WatchShop.XF.Models
{
    public class Watch : ObservableObject
    {
        private string _title;
        private string _image;
        private string _brand;
        private decimal _price;

        public string Title 
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
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

        public string PriceString => $"${Price.ToString()}";

        public string BrandUp => _brand.ToUpper();
    }
}

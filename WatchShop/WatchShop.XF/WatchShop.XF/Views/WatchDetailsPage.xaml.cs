using WatchShop.XF.Models;
using WatchShop.XF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WatchShop.XF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WatchDetailsPage : ContentPage
    {
        public WatchDetailsPage()
        {
            InitializeComponent();
        }

        public WatchDetailsPage(Watch watch)
        {
            InitializeComponent();
            this.BindingContext = new WatchDetailsViewModel(watch);
            ((NavigationPage)App.Current.MainPage).BarBackgroundColor = Color.FromHex("#E1E1E1");
        }
    }
}
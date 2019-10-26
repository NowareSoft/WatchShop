using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;
using WatchShop.XF.Models;
using Xamarin.Forms;

namespace WatchShop.XF.ViewModels
{
    public class WatchDetailsViewModel : ObservableObject
    {
        private Watch _watch;

        public ICommand BackCommand { get; }

        public WatchDetailsViewModel(Watch watch)
        {
            _watch = watch;

            BackCommand = new Command(async () => await BackAsync());
        }

        public Watch Watch
        {
            get => _watch;
            set => SetProperty(ref _watch, value);
        }


        private async Task BackAsync()
        {
            ((NavigationPage)App.Current.MainPage).BarBackgroundColor = Color.White;
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}

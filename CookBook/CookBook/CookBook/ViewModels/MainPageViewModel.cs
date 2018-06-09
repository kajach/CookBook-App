using CookBook.Models;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private MainMenuItem selectedMenuItem;
        public MainMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            NavigateCommand = new DelegateCommand(Navigate);
        }

        async void Navigate()
        {
            await _navigationService.NavigateAsync("NavigationPage/" + SelectedMenuItem.PageName);
        }
    }
}

using CookBook.Models;
using Prism.Navigation;

namespace CookBook.ViewModels
{
    public class ChildBaseViewModel : BaseViewModel
    {
        private Recipe _recipe;
        public Recipe Recipe
        {
            get => _recipe;
            set => SetProperty(ref _recipe, value);
        }

        public ChildBaseViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("recipe"))
                Recipe = parameters.GetValue<Recipe>("recipe");
        }
    }
}

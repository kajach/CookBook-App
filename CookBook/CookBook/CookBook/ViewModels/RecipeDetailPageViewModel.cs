using CookBook.Models;
using Prism.Navigation;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    public class RecipeDetailPageViewModel : BaseViewModel
    {
        public string MainImage
        {
            get { return Recipe.MainImage; }
            set { }
        }
        public string Name
        {
            get { return Recipe.MainImage; }
            set { }
        }

        public Recipe Recipe { get; set; }

        public RecipeDetailPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Recipe = new Recipe()
            {
                Id = 1,
                Name = "Spaghetti Bolognese",
                PreparationTime = "20 min",
                Serves = 2,
                MainImage = "recipe_002.jpg",
                Description = "This pasta is awesome"
            };
        }
    }
}

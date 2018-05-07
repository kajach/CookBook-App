using CookBook.Models;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    public class RecipeDetailViewModel : BaseViewModel
    {
        public Recipe Recipes { get; set; }

        public RecipeDetailViewModel()
        {
            new Recipe()
            {
                Id = 1,
                Name = "Spaghetti Bolognese"
            };
        }
    }
}

using CookBook.Models;
using System.Collections.ObjectModel;

namespace CookBook.ViewModels
{
    public class RecipeListViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public RecipeListViewModel()
        {
            Recipes = new ObservableCollection<Recipe>() {
                new Recipe()
                {
                    Id = 1,
                    Name = "Spaghetti Bolognese"
                },
                new Recipe()
                {
                    Id = 2,
                    Name = "Chocolate Cake"
                },

            };
        }
    }
}

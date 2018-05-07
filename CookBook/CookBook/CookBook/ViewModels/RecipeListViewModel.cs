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
                    Name = "Chicken with dried tomatoes, bacon and asparagus",
                    Category = "Main Dish",
                    MainImage = "recipe_001.jpg"
                },
                new Recipe()
                {
                    Id = 2,
                    Name = "Spaghetti Bolognese",
                    Category = "Main Dish",
                    MainImage = "recipe_002.jpg"
                },
                new Recipe()
                {
                    Id = 3,
                    Name = "Thai Red Curry",
                    Category = "Main Dish",
                    MainImage = "recipe_003.jpg"
                },
                new Recipe()
                {
                    Id = 4,
                    Name = "Lecho",
                    Category = "Main Dish",
                    MainImage = "recipe_004.jpg"
                }
            };
        }
    }
}

using CookBook.Models;
using System;
using System.Collections.ObjectModel;

namespace CookBook.ViewModels
{
    public class RecipeListViewModel
    {
        public ObservableCollection<Recipe> Items { get; set; }

        public RecipeListViewModel()
        {
            Items = new ObservableCollection<Recipe>() {
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

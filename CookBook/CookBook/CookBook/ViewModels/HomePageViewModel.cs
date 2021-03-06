﻿using CookBook.Models;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace CookBook.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> RecipesWithTag { get; set; }

        public HomePageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            RecipesWithTag = new ObservableCollection<Recipe>() {
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
                }
            };
        }
    }
}

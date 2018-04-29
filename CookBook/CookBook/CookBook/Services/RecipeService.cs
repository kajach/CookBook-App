using CookBook.Interfaces;
using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.Services
{
    public class RecipeService : IRecipeService
    {
        IRepository<Recipe> _recipeRepository;
        public RecipeService(IRepository<Recipe> recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
    }
}

using CookBook.Interfaces;
using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.Services
{
    public class IngredientService : IIngredientService
    {
        IRepository<Ingredient> _ingredientRepository;
        public IngredientService(IRepository<Ingredient> ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }
    }
}

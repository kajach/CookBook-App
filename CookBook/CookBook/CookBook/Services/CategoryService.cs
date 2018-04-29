using CookBook.Interfaces;
using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.Services
{
    public class CategoryService : ICategoryService
    {
        IRepository<Category> _categoryRepository;
        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}

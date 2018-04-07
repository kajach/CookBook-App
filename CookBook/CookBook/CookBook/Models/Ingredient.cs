using System;

namespace CookBook.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
    }
}

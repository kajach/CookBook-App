using System;
using System.Collections.Generic;

namespace CookBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PreparationTime { get; set; }
        public int Serves { get; set; }
        public string MainImage { get; set; }
        public string ThumbnailImage { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
    }
}

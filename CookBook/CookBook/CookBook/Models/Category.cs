using System;

namespace CookBook.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }
    }
}

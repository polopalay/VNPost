using System;
namespace VNPost.Models.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Category category &&
                   Id == category.Id;
        }
    }
}

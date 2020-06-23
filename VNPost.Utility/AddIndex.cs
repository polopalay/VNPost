using System;
using Microsoft.EntityFrameworkCore;
using VNPost.Models.Entity;

namespace VNPost.Utility
{
    public class AddIndex
    {
        public static void AddIndexToArticle(ModelBuilder builder)
        {
            builder.Entity<Article>().HasIndex(a => a.DateCreate).HasName("Index_Article_Date");
            builder.Entity<Article>().HasIndex(a => a.View).HasName("Index_Article_View");
        }
    }
}

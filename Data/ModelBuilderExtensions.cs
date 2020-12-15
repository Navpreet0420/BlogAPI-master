using BlogAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedBlogDB(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Travels"
                },
                new Category
                {
                    Id = 2,
                    Name = "Entertainment"
                },
                new Category
                {
                    Id = 3,
                    Name = "Politics"
                }
            );
        }
    }
}

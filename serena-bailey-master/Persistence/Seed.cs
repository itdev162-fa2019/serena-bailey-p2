using System; 
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post!",
                        Date = DateTime.Now.AddDays(-10),
                        Body = "Testing Testing Testing"
                    },
                    new Post {
                        Title = "Second post!",
                        Date = DateTime.Now.AddDays(-7),
                        Body = "Testing Testing Testing"
                    },
                    new Post {
                        Title = "Another day, another post!",
                        Date = DateTime.Now.AddDays(-4),
                        Body = "Testing Testing Testing"
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}
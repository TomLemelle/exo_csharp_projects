using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using portfolio.Data;
using System;
using System.Linq;

namespace portfolio.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new portfolioContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<portfolioContext>>()))
            {
                // Look for any movies.
                if (context.Project.Any())
                {
                    return;   // DB has been seeded
                }

                context.Project.AddRange(
                    new Project
                    {
                        Title = "VueJS Creative Portfolio",
                        Description = "My creative portfolio where all my creations are",
                        Image = "http://www.bigendiandata.com/img/1024px-Vue.js_Logo_2.svg.png",
                        ReleaseDate = DateTime.Parse("2021-10-11"),
                    },
                    new Project
                    {
                        Title = "CV VueJS",
                        Description = "My CV made with VueJS to learn some VueJS technology",
                        Image = "http://www.bigendiandata.com/img/1024px-Vue.js_Logo_2.svg.png",
                        ReleaseDate = DateTime.Parse("2021-09-14"),
                    },

                    new Project
                    {
                        Title = "Covid 19 ReactJS",
                        Description = "Same as Covid 19 CLI but on web application",
                        Image = "http://www.bigendiandata.com/img/1024px-Vue.js_Logo_2.svg.png",
                        ReleaseDate = DateTime.Parse("2021-06-30"),
                    },

                    new Project
                    {
                        Title = "My Website",
                        Description = "A website made with ReactJS to learn some ReactJS technology.",
                        Image = "http://www.bigendiandata.com/img/1024px-Vue.js_Logo_2.svg.png",
                        ReleaseDate = DateTime.Parse("2021-03-24"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
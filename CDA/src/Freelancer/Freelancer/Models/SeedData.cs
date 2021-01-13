using Freelancer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcFreelancerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcFreelancerContext>>()))
            {
               
                if (context.Categories.Any())
                {
                    return;   
                }

                context.Categories.AddRange(
                    new Categories
                    {
                       
                        Nom = "particulier",
                        Description = "il est tout seul le bougre"
                        
                    },

                    new Categories
                    {
                        Nom = "entreprise",
                        Description = "plein d'argent"
                    },

                    new Categories
                    {
                        Nom = "association",
                     
                    },

                    new Categories
                    {
                        Nom = "secteur public",
                        Description = "des fripouilles"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using problemDetails.Models;

namespace problemDetails.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                Console.WriteLine("seeding data");
                context.Products.AddRange(
                    new Product() { Sku = "2345mhg", Name = "Dodge Charger", Units = 5 , Price = 25.6 },
                    new Product() { Sku = "camaro01", Name = "Chevrolet Cambar", Units = 15 , Price = 16.5 }
                       
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We've already have data");
            }

          

            
            


        }
    }
}
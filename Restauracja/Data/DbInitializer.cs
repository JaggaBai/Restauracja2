using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data
{
    public class DbInitializer
    {
        public static void Dane1(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<RestDbContext>();

                context.Database.EnsureCreated();

                //Kilent
                if (!context.Klienci.Any())
                {
                    context.Klienci.AddRange(new List<Klient>()
                    {
                        new Klient()
                        { 
                           NumerStolika = 4
                        },

                    new Klient()
                    {   
                        NumerStolika = 3
                    },
                    new Klient()

                    {   
                        NumerStolika = 10
                    },
                     new Klient()

                    {  
                        NumerStolika = 9
                    },
                    });
                    context.SaveChanges();
                }


   
             

            }
                }
    }
}

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
                    });
                    context.SaveChanges();
                }


                //PozycjaZamowienia
                if (!context.PozycjeZamowienia.Any()) {
                    context.PozycjeZamowienia.AddRange(new List<PozycjaZamowienia>()
                    {
                        new PozycjaZamowienia()
                        {
                        Zdjecie = @"C:\Users\User\source\repos\Restauracja\Restauracja\Data\ZdjeciaLink\casey-lee-awj7sRviVXo-unsplash.jpg",//Casey Lee
                        Nazwa = "Łosoś",
                        KategoriaPozycji=KategoriaPozycji.DanieGlowne,
                        Cena = 15.15,
                        },

                    new PozycjaZamowienia()
                    {
                        Zdjecie = @"C:\Users\User\source\repos\Restauracja\Restauracja\Data\ZdjeciaLink\anna-pelzer-IGfIGP5ONV0-unsplash.jpg", //  Anna Pelzer,
                        Nazwa = "Sałatka",
                        KategoriaPozycji = KategoriaPozycji.DanieGlowne
                        Cena = 30.00,
                    },
                     new PozycjaZamowienia()
                    {
                        Zdjecie = @"C:\Users\User\source\repos\Restauracja\Restauracja\Data\ZdjeciaLink\anna-pelzer-IGfIGP5ONV0-unsplash.jpg", //  Anna Pelzer,
                        Nazwa = "Sałatka",
                        KategoriaPozycji = KategoriaPozycji.DanieGlowne
                        Cena = 30.00,
                    }, 
                    });
                    context.SaveChanges();
                }
             
                //
                if (!context.Zamowienie_PozycjaZamowienia.Any()) { }

                if (!context.Zamownia.Any()) { }
            }
        

            }
                }
    }
}

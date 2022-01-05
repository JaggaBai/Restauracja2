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


        //        //PozycjaZamowienia
        //        if (!context.PozycjeZamowienia.Any()) {
        //            context.PozycjeZamowienia.AddRange(new List<PozycjaZamowienia>()
        //            {
        //                new PozycjaZamowienia()
        //                {
        //                Zdjecie = @"C:\Users\User\source\repos\Restauracja\Restauracja\Data\ZdjeciaLink\casey-lee-awj7sRviVXo-unsplash.jpg",//Casey Lee
        //                Nazwa = "Łosoś",
        //                Nazwa = "Łosoś",
        //                KategoriaPozycji=KategoriaPozycji.DanieGlowne,
        //                Cena = 15.15M,
        //                },

        //            new PozycjaZamowienia()
        //            {
        //                Zdjecie = @"C:\Users\User\source\repos\Restauracja\Restauracja\Data\ZdjeciaLink\anna-pelzer-IGfIGP5ONV0-unsplash.jpg", //  Anna Pelzer,
        //                Nazwa = "Sałatka",
        //                KategoriaPozycji = KategoriaPozycji.DanieGlowne,
        //                Cena = 30.00M,
        //            },
        //             new PozycjaZamowienia()
        //            {
        //                Zdjecie = @"C:\Users\User\source\repos\Restauracja\Restauracja\Data\ZdjeciaLink\the-creative-exchange-gA81ZTsql68-unsplash.jpg", //  The Creative Exchange,
        //                Nazwa = "Sok",
        //                KategoriaPozycji = KategoriaPozycji.Napoj,
        //                Cena = 8.00M,
        //            },

        //            new PozycjaZamowienia()
        //            {
        //                Zdjecie = @"C:\Users\User\source\repos\Restauracja\Restauracja\Data\ZdjeciaLink\megan-bucknall-qav5LFLbSUk-unsplash.jpg", // Megan Bucknall
        //                Nazwa = "Sok",
        //                KategoriaPozycji = KategoriaPozycji.Zupa,
        //                Cena = 9.00M,
        //            },
        //            });

        //            context.SaveChanges();
        //        }

        //        //poz-zam
        //        if (!context.Zamowienie_PozycjaZamowienia.Any()) {
        //            context.Zamowienie_PozycjaZamowienia.AddRange(new List<Zamowienie_PozycjaZamowienia>()
        //            {
        //                new Zamowienie_PozycjaZamowienia()
        //                {
        //                  IdZamownie=1,
        //                  IdPozycji=1,
        //        },
        //                 new Zamowienie_PozycjaZamowienia()
        //                {
        //                  IdZamownie=2,
        //                  IdPozycji=3,
        //        },
        //                new Zamowienie_PozycjaZamowienia()
        //                {
        //                  IdZamownie=3,
        //                  IdPozycji=2,
        //        },
        //                new Zamowienie_PozycjaZamowienia()
        //                {
        //                  IdZamownie=3,
        //                  IdPozycji=1,
        //        },
        //            });

        //            context.SaveChanges();
        //        }


   
             

            }
                }
    }
}

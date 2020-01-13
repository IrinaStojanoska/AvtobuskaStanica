namespace AvtobuskaStanica.Migrations
{
    using AvtobuskaStanica.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AvtobuskaStanica.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AvtobuskaStanica.Models.ApplicationDbContext context)
        {
            context.Relations.AddOrUpdate(
                new Relation()
                {
                    id = 1,
                    fromDestination = "Ohrid",
                    toDestination = "Skopje",
                    time = "06:40",
                    company = "Strumica Express",
                    capacity = 45,
                    priceOneWay=120,
                    priceRoundTrip=350
                }
                );
            context.Relations.Add(
                   new Relation()
                   {
                       id = 2,
                       fromDestination = "Ohrid",
                       toDestination = "Bitola",
                       time = "06:50",
                       company = "Metro Trans",
                       capacity = 32,
                       priceOneWay = 220,
                       priceRoundTrip = 400
                   });
           context.Relations.Add(
           new Relation()
            {
                id = 3,
                fromDestination = "Ohrid",
                toDestination = "Tetovo",
                time = "07:10",
                company = "Galeb",
                capacity = 35,
               priceOneWay = 370,
               priceRoundTrip = 550
           });

           context.Relations.Add(
              new Relation()
               {
                   id = 4,
                   fromDestination = "Ohrid",
                   toDestination = "Prilep",
                   time = "07:45",
                   company = "Delfina",
                   capacity = 27,
                  priceOneWay = 240,
                  priceRoundTrip = 500
              });

            context.Relations.Add(
            new Relation()
            {
                id = 5,
                fromDestination = "Ohrid",
                toDestination = "Strumica",
                company = "Rule Turs",
                time = "06:40",
                capacity = 45,
                priceOneWay = 270,
                priceRoundTrip = 400
            });

            context.Relations.Add(
                      new Relation()
                      {
                          id = 6,
                          fromDestination = "Ohrid",
                          toDestination = "Struga",
                          company = "Transkop",
                          time = "80:10",
                          capacity = 45,
                          priceOneWay = 320,
                          priceRoundTrip = 580
                      });

               context.Relations.Add(
                         new Relation()
                         {
                             id = 7,
                             fromDestination = "Ohrid",
                             toDestination = "Skopje",
                             company = "Pelagonija",
                             time = "08:45",
                             capacity = 45,
                             priceOneWay = 380,
                             priceRoundTrip = 650
                         });
            context.Relations.Add(
            new Relation()
            {
                id = 3,
                fromDestination = "Ohrid",
                toDestination = "Tetovo",
                time = "07:10",
                company = "Galeb",
                capacity = 35,
                priceOneWay = 120,
                priceRoundTrip = 350
            });

            context.Relations.Add(
               new Relation()
               {
                   id = 4,
                   fromDestination = "Ohrid",
                   toDestination = "Prilep",
                   time = "07:45",
                   company = "Delfina",
                   capacity = 27,
                   priceOneWay = 250,
                   priceRoundTrip = 450
               });
            context.Relations.Add(
                  new Relation()
                  {
                      id = 5,
                      fromDestination = "Ohrid",
                      toDestination = "Strumica",
                      company = "Rule Turs",
                      time = "06:40",
                      capacity = 45,
                      priceOneWay = 430,
                      priceRoundTrip = 700
                  });

            context.Relations.Add(
                      new Relation()
                      {
                          id = 6,
                          fromDestination = "Ohrid",
                          toDestination = "Struga",
                          company = "Transkop",
                          time = "80:10",
                          capacity = 45,
                          priceOneWay = 120,
                          priceRoundTrip = 350
                      });
            context.Relations.Add(
                          new Relation()
                          {
                              id = 7,
                              fromDestination = "Ohrid",
                              toDestination = "Skopje",
                              company = "Pelagonija",
                              time = "08:45",
                              capacity = 45,
                              priceOneWay = 400,
                              priceRoundTrip = 650
                          });


           
        }
    }
}

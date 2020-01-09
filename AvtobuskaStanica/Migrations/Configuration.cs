namespace AvtobuskaStanica.Migrations
{
    using AvtobuskaStanica.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AvtobuskaStanica.Context.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AvtobuskaStanica.Context.DatabaseContext context)
        {
            context.Relations.AddOrUpdate(
        new Relation() { id = 1, fromDestination = "Ohrid", toDestination="Skopje", priceOneWay=300, priceRoundTrip=550, capacity=23, time="08:40", company="Galeb" },
        new Relation() { id = 2, fromDestination = "Ohrid", toDestination="Tetovo", priceOneWay=200, priceRoundTrip=350, capacity=23, time="08:50", company="Pelagonija" },
        new Relation() { id = 3, fromDestination = "Ohrid", toDestination="Bitola", priceOneWay=150, priceRoundTrip=600, capacity=23, time="09:00", company="Metro Trans" },
        new Relation() { id = 4, fromDestination = "Ohrid", toDestination="Prilep", priceOneWay=300, priceRoundTrip=560, capacity=23, time="10:40", company="Rule turs" },
        new Relation() { id = 5, fromDestination = "Ohrid", toDestination="Struga", priceOneWay=120, priceRoundTrip=200, capacity=23, time="11:20", company="Delfina" }
       
        );

            context.Customers.AddOrUpdate(
                new Customer() { id=1, serialNumber=43434, name="John", cardNumber=75747}
                );
        }
    }
}

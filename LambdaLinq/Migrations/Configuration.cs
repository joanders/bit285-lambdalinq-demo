namespace LambdaLinq.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LambdaLinq.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LambdaLinq.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "LambdaLinq.Models.BookstoreDbContext";
        }

        protected override void Seed(LambdaLinq.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //
            context.Books.AddOrUpdate(b=>b.BookID,
        new Book()
        {
            BookID = 1,
            Title = "Pride and Prejudice",
            Author = "Jane Austin",
            Price = 9.99M
        },
        new Book()
        {
            BookID = 2,
            Title = "Northanger Abbey",
            Author = "Jane Austin",
            Price = 12.95M
        },
        new Book()
        {
            BookID = 3,
            Title = "David Copperfield",
            Author = "Charles Dickens",
            Price = 15.00M
        },
        new Book()
        {
            BookID = 4,
            Title = "The Wizard of EarthSea",
            Author = "Ursula Le Guin",
            Price = 8.95M
        },
        new Book()
        {
            BookID = 5,
            Title = "The Tombs of Atuan",
            Author = "Ursula Le Guin",
            Price = 7.95M
        },
        new Book()
        {
            BookID = 6,
            Title = "The Farthest Shore",
            Author = "Ursula Le Guin",
            Price = 9.95M
        },
           //  TODO: Add two additional books to the seed data and update the database

           new Book()
           {
               BookID = 7,
               Title = "Americanah",
               Author = "Chimamanda Ngozi Adichie",
               Price = 10.99M
           },
              new Book()
              {
                  BookID = 8,
                  Title = "The Feminine Mystique",
                  Author = "Betty Friedan",
                  Price = 9.99M
              });

        }
    }
}

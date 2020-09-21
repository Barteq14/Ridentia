using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.DAL
{
    public class RidentiaDbInitializer
    {
        public static void Initialize(RidentiaDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Characters.Any())
            {
                return;   // DB has been seeded
            }
            /*
            // authors
            var author = new Author[]
            {
                new Author { FirstName = "Bartek", LastName="Kowalski" },
                new Author { FirstName = "Przemek", LastName="Rozbicki" },
                new Author { FirstName = "Grzegorz", LastName="Malarz" },
                new Author { FirstName = "Małgorzata", LastName="Bronowska" },
                new Author { FirstName = "Kacper", LastName="Kunicki" },
                new Author { FirstName = "Teresa", LastName="Sowa" },
                new Author { FirstName = "Katarzyna", LastName="Kruk" },
                new Author { FirstName = "Antoni", LastName="Lis" }
            };
            foreach (Author a in author)
            {
                context.Authors.Add(a);
            }
            context.SaveChanges();

            //Publish houses
            var publishHouses = new PublishHouse[]
            {
                new PublishHouse { PublishHouseName = "Nowa Era" , PublishmentYear = 2010 },
                new PublishHouse { PublishHouseName = "Helion" , PublishmentYear = 2009 },
                new PublishHouse { PublishHouseName = "Wyd1" , PublishmentYear = 2001 },
                new PublishHouse { PublishHouseName = "Tonkiel" , PublishmentYear = 1996 },
                new PublishHouse { PublishHouseName = "Ridentia" , PublishmentYear = 2014 },
                new PublishHouse { PublishHouseName = "Ridentia" , PublishmentYear = 2011 },
                new PublishHouse { PublishHouseName = "Nowa Era" , PublishmentYear = 2017 },
                new PublishHouse { PublishHouseName = "Helion" , PublishmentYear = 2019 }
            };
            foreach (PublishHouse ph in publishHouses)
            {
                context.PublishHouses.Add(ph);
            }
            context.SaveChanges();

            //Categories - kind of books
            var categories = new Category[]
            {
                new Category { KindOfBook = "Książka" },
                new Category { KindOfBook = "Ebook" },
                new Category { KindOfBook = "Podręcznik" },
                new Category { KindOfBook = "Audiobook" },
                new Category { KindOfBook = "Czasopismo" }
            };
            foreach (Category cat in categories)
            {
                context.Categories.Add(cat);
            }
            context.SaveChanges();

            // book categories
            var bookCategory = new BookCategory[]
            {
                new BookCategory { CategoryBook = "Przygodowa" },
                new BookCategory { CategoryBook = "Informatyczna" },
                new BookCategory { CategoryBook = "Historyczna" },
                new BookCategory { CategoryBook = "Audiobook" }
            };
            foreach (BookCategory bc in bookCategory)
            {
                context.BookCategories.Add(bc);
            }
            context.SaveChanges();

            var books = new Book[]
            {
                new Book { Title = "tytul1", Price = 99.99 , Quantity = 15, NumberOfPages = 300, IBSN = "123456789101", Binding = "Twarda okładka", Description = "adasdashdjahsdkahsdjkahsdjasgdhasgdjashdjkasdhsajdhasjkdhasjkdhas", Author = author[0], PublishHouse = publishHouses[0], BookCategory = bookCategory[0], Category = categories[0]},
                new Book { Title = "ksiazka1", Price = 39.90 , Quantity = 9, NumberOfPages = 350, IBSN = "123456789102", Binding = "Twarda okładka", Description = "adasdashdjahsdkahsdjkahsdjasgdhasgdjashdjkasdhsajdhasjkdhasjkdhas", Author = author[0], PublishHouse = publishHouses[0], BookCategory = bookCategory[0], Category = categories[0]},
                new Book { Title = "ebook1", Price = 40.05 , Quantity = 10, NumberOfPages = 157, IBSN = "123456789103", Binding = "wersja elektroniczna", Description = "adasdashdjahsdkahsdjkahsdjasgdhasgdjashdjkasdhsajdhasjkdhasjkdhas", Author = author[1], PublishHouse = publishHouses[1], BookCategory = bookCategory[1], Category = categories[1]},
                new Book { Title = "podrecznik1", Price = 105.99 , Quantity = 7, NumberOfPages = 290, IBSN = "123456789104", Binding = "miekka okładka", Description = "adasdashdjahsdkahsdjkahsdjasgdhasgdjashdjkasdhsajdhasjkdhasjkdhas", Author = author[2], PublishHouse = publishHouses[2], BookCategory = bookCategory[2], Category = categories[0]},
                new Book { Title = "audiobook1", Price = 16.99 , Quantity = 5, NumberOfPages = 20, IBSN = "123456789105", Binding = "wersja audio", Description = "adasdashdjahsdkahsdjkahsdjasgdhasgdjashdjkasdhsajdhasjkdhasjkdhas", Author = author[3], PublishHouse = publishHouses[3], BookCategory = bookCategory[3], Category = categories[3]}
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();
            */
        }
    }
}

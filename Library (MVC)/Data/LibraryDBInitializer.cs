using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Library__MVC_.Models;
using Library__MVC_.Data;

namespace Library__MVC_.Data
{
    public static class LibraryDBInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            if (context.Books.Any())
            {
                return;
            }

            var books = new Book[]
            {
            new Book{Name = "Война и мир"},
            new Book{Name = "Отцы и дети"},
            new Book{Name = "Чайка"},
            new Book{Name = "Мастер и Маргарита"},
            new Book{Name = "Недоросль"},
            new Book{Name = "Народные сказки"}
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();

            var authors = new Author[]
            {
            new Author{AuthorID = 101, FirstName = "Лев", LastName = "Толстой", MiddleName = "Николаевич", BirthDate = DateTime.Parse("1828-09-09"), DeathDate = DateTime.Parse("1910-11-20")},
            new Author{AuthorID = 102, FirstName = "Иван", LastName = "Тургенев", MiddleName = "Сергеевич", BirthDate = DateTime.Parse("1818-11-09"), DeathDate = DateTime.Parse("1883-09-03")},
            new Author{AuthorID = 103, FirstName = "Антон", LastName = "Чехов", MiddleName = "Павлович", BirthDate = DateTime.Parse("1860-01-29"), DeathDate = DateTime.Parse("1904-07-15")},
            new Author{AuthorID = 104, FirstName = "Михаил", LastName = "Булгаков", MiddleName = "Афанасьевич", BirthDate = DateTime.Parse("1891-05-15"), DeathDate = DateTime.Parse("1940-03-10")},
            new Author{AuthorID = 105, FirstName = "Денис", LastName = "Фонвизин", MiddleName = "Иванович", BirthDate = DateTime.Parse("1745-04-14"), DeathDate = DateTime.Parse("1792-12-12")}
            };
            foreach (Author a in authors)
            {
                context.Authors.Add(a);
            }
            context.SaveChanges();

            var publishers = new Publisher[]
            {
            new Publisher{PublisherID = 1001, Name = "Графа", Address = "г. Москва", INN = 123456561},
            new Publisher{PublisherID = 1002, Name = "Издательство", Address = "г. Москва", INN = 123456567},
            new Publisher{PublisherID = 1003, Name = "Пифагор", Address = "г. Санкт-Петербург", INN = 156456563},
            new Publisher{PublisherID = 1004, Name = "Просвещение", Address = "г. Екатеринбург", INN = 178956567},
            new Publisher{PublisherID = 1005, Name = "Эксмо", Address = "г. Нижни Новгород", INN = 144456568},
            };
            foreach (Publisher p in publishers)
            {
                context.Publishers.Add(p);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{BookID = 1, AuthorID = 101, PublisherID = 1001},
            new Enrollment{BookID = 2, AuthorID = 102, PublisherID = 1002},
            new Enrollment{BookID = 3, AuthorID = 103, PublisherID = 1003},
            new Enrollment{BookID = 4, AuthorID = 104, PublisherID = 1004},
            new Enrollment{BookID = 5, AuthorID = 105, PublisherID = 1005},
            new Enrollment{BookID = 1, AuthorID = 101, PublisherID = 1005}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();

        }
    }
}



//namespace LibraryFront.Models
//{
//    public class LibraryDBInitializer : DropCreateDatabaseAlways<LibraryContext>
//    {
//        protected override void Seed(LibraryContext db)
//        {
//            db.Books.Add(new Book { name = "Народные сказки", author = "Ю. Грачев", publishingHouse = "Пифагор" });
//            db.Books.Add(new Book { name = "Война и мир", author = "Л. Толстой", publishingHouse = "Графа" });
//            db.Books.Add(new Book { name = "Отцы и дети", author = "И. Тургенев", publishingHouse = "Графа" });
//            db.Books.Add(new Book { name = "Чайка", author = "А. Чехов", publishingHouse = "Графа" });

//            base.Seed(db);
//        }

//    }
//}
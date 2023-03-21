using System;
using System.Collections.Generic;
using System.Linq;
using Library;
using Library.enums;

namespace LibraryDAL
{
    public class Data : IData
    {
        public IEnumerable<Genre> Genres => new List<Genre>()
        {
            new Genre()
            {
                pGenre = Library.enums.Genres.Drama
            },
            new Genre()
            {
                pGenre = Library.enums.Genres.Novelette
            },
            new Genre()
            {
                pGenre = Library.enums.Genres.Poem
            },
            new Genre()
            {
                pGenre = Library.enums.Genres.Poetry
            }
        };
        public IEnumerable<Author> Authors => new List<Author>()
        {
            new Author
            {
                Name = "Iван Котляревський"
            },
            new Author
            {
                Name = "Микола Гоголь"
            },
            new Author
            {
                Name = "Тарас Шевченко"
            },
            new Author
            {
                Name = "Леся Українка"
            },
            new Author
            {
                Name = "Сергій Жадан"
            },
            new Author
            {
                Name = "Юрій Винничук"
            },
            new Author
            {
                Name = "Ліна Костенко"
            },
            new Author
            {
                Name = "Софія Андрухович"
            },
            new Author
            {
                Name = "Всеволод Нестайко"
            },
            new Author
            {
                Name = "Василь Стефанник"
            },
            new Author
            {
                Name = "Мар’яна Савка"
            },
            new Author
            {
                Name = "Юрій Андрухович"
            },
            new Author
            {
                Name = "Костянтин Москалець"
            }

        };
        public IEnumerable<Client> Clients => new List<Client>()
        {
            new Client()
            {
                FullName = "Броварчук Полiна Олексiiвна",
                Adress = "Херсонська область, мiсто Херсон, просп. Рiзницька, 06",
                Phone = "0667743639",
                Category = Categories.Student
            },
            new Client()
            {
                FullName = "Шинкаренко Катерина Романiвнa",
                Adress = "Тернопiльська область, мiсто Тернопiль, пров. i. Франкa, 16",
                Phone = "0666874997",
                Category = Categories.Schoolkid
            },
            new Client()
            {
                FullName = "Таращук Катерина Борисiвна",
                Adress = "Полтавська область, мiсто Полтава, пл. Урицького, 45",
                Phone = "0923715297",
                Category = Categories.Renter
            },
            new Client()
            {
                FullName = "Кравчук Денис Iванович",
                Adress = "Київська область, мiсто Київ, пл. Арсенальна, 01",
                Phone = "0977419693",
                Category = Categories.Renter
            },
            new Client()
            {
                FullName = "Таращук Володимир Янович",
                Adress = "Сумська область, місто Суми, пров. Шота Руставелі, 47",
                Phone = "0686500242",
                Category = Categories.Schoolkid
            },
            new Client()
            {
                FullName = "Шинкаренко Катерина Володимирівна",
                Adress = "Закарпатська область, місто Ужгород, вул. Урицького, 18",
                Phone = "0682255806",
                Category = Categories.Student
            },
            new Client()
            {
                FullName = "Васильєв Олександра Андріївна",
                Adress = "Львівська область, місто Львів, просп. Урицького, 07",
                Phone = "0666054598",
                Category = Categories.Renter
            },
            new Client()
            {
                FullName = "Шевченко Олексій Анатолійович",
                Adress = "Одеська область, місто Одеса, вул. Солом’янська, 02",
                Phone = "0930132800",
                Category = Categories.Student
            },
            new Client()
            {
                FullName = "Мельниченко Артем Петрович",
                Adress = "Харківська область, місто Харків, вул. Урицького, 25",
                Phone = "0507201916",
                Category = Categories.Renter
            }

        };
        public  IEnumerable<Book> Books => new List<Book> ()
        {
            new Book()
            {
                Name = "Енеїда",
                Amount = 4,
                GenreId = Genres.ElementAt(2).Id,
                CollateralValue = 54.54M,

            },
            new Book()
            {
                Name = "Вечори на хуторi бiля Диканьки",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 2,
                CollateralValue = 72.54M,

            },
            new Book()
            {
                Name = "Кобзар",
                GenreId = Genres.ElementAt(3).Id,
                Amount = 7,
                CollateralValue = 59.254M,
            },
            new Book()
            {
                Name = "Лiсова пiсня",
                GenreId = Genres.ElementAt(0).Id,
                Amount = 9,
                CollateralValue = 59.254M,
            },
            new Book()
            {
                Name = "Ворошиловоград",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 2,
                CollateralValue = 89.254M,
            },
            new Book()
            {
                Name = "Танго Смерті",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 4,
                CollateralValue = 49.254M,
            },
            new Book()
            {
                Name = "Маруся Чурай",
                GenreId = Genres.ElementAt(3).Id,
                Amount = 4,
                CollateralValue = 70.254M,
            },
            new Book()
            {
                Name = "Амадока",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 6,
                CollateralValue = 80.166M,
            },
            new Book()
            {
                Name = "Тореодори з Васюківки",
                GenreId = Genres.ElementAt(2).Id,

                Amount = 12,
                CollateralValue = 30.166M,
            },
            new Book()
            {
                Name = "Камінний Хрест",
                GenreId = Genres.ElementAt(2).Id,
                Amount = 8,
                CollateralValue = 99.166M,
            },
            new Book()
            {
                Name = "Iнтернат",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 5,
                CollateralValue = 66.354M,
            },
            new Book()
            {
                Name = "То є Львiв. Колекцiя мiських iсторiй",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 5,
                CollateralValue = 66.354M,
            }
        };
        
        public  IEnumerable<Subscription> Subscriptions => new List<Subscription>()
        {
            new Subscription()
            {
                BookId = Books.ElementAt(0).Id,
                ClientId = Clients.ElementAt(0).Id,
                DateOfIssue = DateTime.Now,
                ExpectedReturnDate = DateTime.Now.AddMonths(2)
            },
            new Subscription()
            {
                BookId = Books.ElementAt(1).Id,
                ClientId = Clients.ElementAt(2).Id,
                DateOfIssue = DateTime.Now.AddMonths(-1),
                ExpectedReturnDate = DateTime.Now.AddMonths(2)
            },
            new Subscription()
            {
                BookId = Books.ElementAt(2).Id,
                ClientId = Clients.ElementAt(1).Id,
                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(4)
            },
            new Subscription()
            {
                BookId = Books.ElementAt(1).Id,
                ClientId = Clients.ElementAt(1).Id,
                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(4)
            },
            new Subscription()
            {
                BookId = Books.ElementAt(2).Id,
                ClientId = Clients.ElementAt(3).Id,
                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(-1)
            },
            new Subscription()
            {
                BookId = Books.ElementAt(4).Id,
                ClientId = Clients.ElementAt(6).Id,

                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(2)
            },
            new Subscription()
            {
                BookId = Books.ElementAt(7).Id,
                ClientId = Clients.ElementAt(2).Id,
                DateOfIssue = DateTime.Now.AddMonths(-1),
                ExpectedReturnDate = DateTime.Now.AddMonths(5)
            }
        };
       
        
        public IEnumerable<Co_Author> Co_Authors => new List<Co_Author>()
        {
            new Co_Author
            {
                AuthorId = Authors.ElementAt(0).Id,
                BookId = Books.ElementAt(0).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(1).Id,
                BookId = Books.ElementAt(1).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(2).Id,
                BookId = Books.ElementAt(2).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(3).Id,
                BookId = Books.ElementAt(3).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(4).Id,
                BookId = Books.ElementAt(4).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(5).Id,
                BookId = Books.ElementAt(5).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(6).Id,
                BookId = Books.ElementAt(6).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(6).Id,
                BookId = Books.ElementAt(6).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(7).Id,
                BookId = Books.ElementAt(7).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(8).Id,
                BookId = Books.ElementAt(8).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(9).Id,
                BookId = Books.ElementAt(9).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(10).Id,
                BookId = Books.ElementAt(10).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(11).Id,
                BookId = Books.ElementAt(10).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(12).Id,
                BookId = Books.ElementAt(10).Id
            },
            new Co_Author
            {
                AuthorId = Authors.ElementAt(13).Id,
                BookId = Books.ElementAt(10).Id
            },
        };
    }
}

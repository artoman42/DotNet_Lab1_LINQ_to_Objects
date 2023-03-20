using System;
using System.Collections.Generic;
using Library;
using Library.enums;

namespace LibraryDAL
{
    public class Data : IData
    {
        public static List<Book> Books = new ()
        {
            new Book()
            {
                Name = "Енеїда",
                Amount = 4,
                GenreId = Genres[2].Id,
                CollateralValue = 54.54M,

            },
            new Book()
            {
                Name = "Вечори на хуторi бiля Диканьки",
                GenreId = Genres[1].Id,
                Amount = 2,
                CollateralValue = 72.54M,

            },
            new Book()
            {
                Name = "Кобзар",
                GenreId = Genres[3].Id,
                Amount = 7,
                CollateralValue = 59.254M,
            },
            new Book()
            {
                Name = "Лiсова пiсня",
                GenreId = Genres[0].Id,
                Amount = 9,
                CollateralValue = 59.254M,
            },
            new Book()
            {
                Name = "Ворошиловоград",
                GenreId = Genres[1].Id,
                Amount = 2,
                CollateralValue = 89.254M,
            },
            new Book()
            {
                Name = "Танго Смерті",
                GenreId = Genres[1].Id,
                Amount = 4,
                CollateralValue = 49.254M,
            },
            new Book()
            {
                Name = "Маруся Чурай",
                GenreId = Genres[3].Id,
                Amount = 4,
                CollateralValue = 70.254M,
            },
            new Book()
            {
                Name = "Амадока",
                GenreId = Genres[1].Id,
                Amount = 6,
                CollateralValue = 80.166M,
            },
            new Book()
            {
                Name = "Тореодори з Васюківки",
                GenreId = Genres[2].Id,

                Amount = 12,
                CollateralValue = 30.166M,
            },
            new Book()
            {
                Name = "Камінний Хрест",
                GenreId = Genres[2].Id,
                Amount = 8,
                CollateralValue = 99.166M,
            },
            new Book()
            {
                Name = "Iнтернат",
                GenreId = Genres[1].Id,
                Amount = 5,
                CollateralValue = 66.354M,
            },
            new Book()
            {
                Name = "То є Львiв. Колекцiя мiських iсторiй",
                GenreId = Genres[1].Id,
                Amount = 5,
                CollateralValue = 66.354M,
            }
        };
        public static List<Client> Clients = new()
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
        public static List<Subscription> Subscriptions = new()
        {
            new Subscription()
            {
                BookId = Books[0].Id,
                ClientId = Clients[0].Id,
                DateOfIssue = DateTime.Now,
                ExpectedReturnDate = DateTime.Now.AddMonths(2)
            },
            new Subscription()
            {
                BookId = Books[1].Id,
                ClientId = Clients[2].Id,
                DateOfIssue = DateTime.Now.AddMonths(-1),
                ExpectedReturnDate = DateTime.Now.AddMonths(2)
            },
            new Subscription()
            {
                BookId = Books[2].Id,
                ClientId = Clients[1].Id,
                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(4)
            },
            new Subscription()
            {
                BookId = Books[1].Id,
                ClientId = Clients[1].Id,
                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(4)
            },
            new Subscription()
            {
                BookId = Books[2].Id,
                ClientId = Clients[3].Id,
                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(-1)
            },
            new Subscription()
            {
                BookId = Books[4].Id,
                ClientId = Clients[6].Id,

                DateOfIssue = DateTime.Now.AddMonths(-3),
                ExpectedReturnDate = DateTime.Now.AddMonths(2)
            },
            new Subscription()
            {
                BookId = Books[7].Id,
                ClientId = Clients[2].Id,
                DateOfIssue = DateTime.Now.AddMonths(-1),
                ExpectedReturnDate = DateTime.Now.AddMonths(5)
            }
        };
        public static List<Genre> Genres = new()
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
        public static List<Author> Authors = new()
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
        public static List<Co_Author> Co_Authors = new()
        {
            new Co_Author
            {
                AuthorId = Authors[0].Id,
                BookId = Books[0].Id
            },
            new Co_Author
            {
                AuthorId = Authors[1].Id,
                BookId = Books[1].Id
            },
            new Co_Author
            {
                AuthorId = Authors[2].Id,
                BookId = Books[2].Id
            },
            new Co_Author
            {
                AuthorId = Authors[3].Id,
                BookId = Books[3].Id
            },
            new Co_Author
            {
                AuthorId = Authors[4].Id,
                BookId = Books[4].Id
            },
            new Co_Author
            {
                AuthorId = Authors[5].Id,
                BookId = Books[5].Id
            },
            new Co_Author
            {
                AuthorId = Authors[6].Id,
                BookId = Books[6].Id
            },
            new Co_Author
            {
                AuthorId = Authors[6].Id,
                BookId = Books[6].Id
            },
            new Co_Author
            {
                AuthorId = Authors[7].Id,
                BookId = Books[7].Id
            },
            new Co_Author
            {
                AuthorId = Authors[8].Id,
                BookId = Books[8].Id
            },
            new Co_Author
            {
                AuthorId = Authors[9].Id,
                BookId = Books[9].Id
            },
            new Co_Author
            {
                AuthorId = Authors[10].Id,
                BookId = Books[10].Id
            },
            new Co_Author
            {
                AuthorId = Authors[11].Id,
                BookId = Books[10].Id
            },
            new Co_Author
            {
                AuthorId = Authors[12].Id,
                BookId = Books[10].Id
            },
            new Co_Author
            {
                AuthorId = Authors[13].Id,
                BookId = Books[10].Id
            },
        };
    }
}

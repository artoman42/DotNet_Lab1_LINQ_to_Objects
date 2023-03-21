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
                Id = 0,
                pGenre = Library.enums.Genres.Drama
            },
            new Genre()
            {
                Id = 1,
                pGenre = Library.enums.Genres.Novelette
            },
            new Genre()
            {
                Id = 2,
                pGenre = Library.enums.Genres.Poem
            },
            new Genre()
            {
                Id = 3,
                pGenre = Library.enums.Genres.Poetry
            }
        };
        public IEnumerable<Author> Authors => new List<Author>()
        {
            new Author
            {
                Id = 0,
                Name = "Iван Котляревський"
            },
            new Author
            {
                Id = 1,
                Name = "Микола Гоголь"
            },
            new Author
            {
                Id = 2,
                Name = "Тарас Шевченко"
            },
            new Author
            {
                Id=3,
                Name = "Леся Українка"
            },
            new Author
            {

                Id =4,
                Name = "Сергій Жадан"
            },
            new Author
            {

                Id=5,
                Name = "Юрій Винничук"
            },
            new Author
            {
                Id = 6,
                Name = "Ліна Костенко"
            },
            new Author
            {

                Id = 7,
                Name = "Софія Андрухович"
            },
            new Author
            {

                Id = 8,
                Name = "Всеволод Нестайко"
            },
            new Author
            {
                Id = 9,
                Name = "Василь Стефанник"
            },
            new Author
            {
                Id=10,
                Name = "Мар’яна Савка"
            },
            new Author
            {
                Id=11,
                Name = "Юрій Андрухович"
            },
            new Author
            {
                Id = 12,
                Name = "Костянтин Москалець"
            }

        };
        public IEnumerable<Client> Clients => new List<Client>()
        {
            new Client()
            {
                Id = 0,
                FullName = "Броварчук Полiна Олексiiвна",
                Adress = "Херсонська область, мiсто Херсон, просп. Рiзницька, 06",
                Phone = "0667743639",
                Category = Categories.Student
            },
            new Client()
            {
                Id = 1,
                FullName = "Шинкаренко Катерина Романiвнa",
                Adress = "Тернопiльська область, мiсто Тернопiль, пров. i. Франкa, 16",
                Phone = "0666874997",
                Category = Categories.Schoolkid
            },
            new Client()
            {
                Id = 2,
                FullName = "Таращук Катерина Борисiвна",
                Adress = "Полтавська область, мiсто Полтава, пл. Урицького, 45",
                Phone = "0923715297",
                Category = Categories.Renter
            },
            new Client()
            {Id = 3,
                FullName = "Кравчук Денис Iванович",
                Adress = "Київська область, мiсто Київ, пл. Арсенальна, 01",
                Phone = "0977419693",
                Category = Categories.Renter
            },
            new Client()
            {
                Id = 4,
                FullName = "Таращук Володимир Янович",
                Adress = "Сумська область, місто Суми, пров. Шота Руставелі, 47",
                Phone = "0686500242",
                Category = Categories.Schoolkid
            },
            new Client()
            {
                Id= 5,
                FullName = "Шинкаренко Катерина Володимирівна",
                Adress = "Закарпатська область, місто Ужгород, вул. Урицького, 18",
                Phone = "0682255806",
                Category = Categories.Student
            },
            new Client()
            {
                Id=6, 
                FullName = "Васильєв Олександра Андріївна",
                Adress = "Львівська область, місто Львів, просп. Урицького, 07",
                Phone = "0666054598",
                Category = Categories.Renter
            },
            new Client()
            {
                Id=7,
                FullName = "Шевченко Олексій Анатолійович",
                Adress = "Одеська область, місто Одеса, вул. Солом’янська, 02",
                Phone = "0930132800",
                Category = Categories.Student
            },
            new Client()
            {
                Id=8,
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
                Id=0,
                Name = "Енеїда",
                Amount = 4,
                GenreId = 2,
                CollateralValue = 54.54M,

            },
            new Book()
            {
                Id = 0,
                Name = "Вечори на хуторi бiля Диканьки",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 2,
                CollateralValue = 72.54M,

            },
            new Book()
            {
                Id = 1,
                Name = "Кобзар",
                GenreId = Genres.ElementAt(3).Id,
                Amount = 7,
                CollateralValue = 59.254M,
            },
            new Book()
            {
                Id=2,
                Name = "Лiсова пiсня",
                GenreId = Genres.ElementAt(0).Id,
                Amount = 9,
                CollateralValue = 59.254M,
            },
            new Book()
            {
                Id=3,
                Name = "Ворошиловоград",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 2,
                CollateralValue = 89.254M,
            },
            new Book()
            {
                Id=4,
                Name = "Танго Смерті",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 4,
                CollateralValue = 49.254M,
            },
            new Book()
            {
                Id=5,
                Name = "Маруся Чурай",
                GenreId = Genres.ElementAt(3).Id,
                Amount = 4,
                CollateralValue = 70.254M,
            },
            new Book()
            {
                Id=6,
                Name = "Амадока",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 6,
                CollateralValue = 80.166M,
            },
            new Book()
            {
                Id=7,
                Name = "Тореодори з Васюківки",
                GenreId = Genres.ElementAt(2).Id,

                Amount = 12,
                CollateralValue = 30.166M,
            },
            new Book()
            {
                Id=8,
                Name = "Камінний Хрест",
                GenreId = Genres.ElementAt(2).Id,
                Amount = 8,
                CollateralValue = 99.166M,
            },
            new Book()
            {
                Id =9,
                Name = "Iнтернат",
                GenreId = Genres.ElementAt(1).Id,
                Amount = 5,
                CollateralValue = 66.354M,
            },
            new Book()
            {
                Id=10,
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
            }
        };
    }
}

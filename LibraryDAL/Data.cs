using System;
using System.Collections.Generic;
using Library;
using Library.enums;
namespace LibraryDAL
{
    public class Data
    {
        public static List<Book> Books = new()
        {
            new Book()
            {
                Name = "Енеїда",
                Author = "Iван Котляревський",
                Genre = Genres.Poem,

                Amount = 4,
                RentCost = new RentCost()
                {
                    CollateralValue = 54.54,
                    RentalPrice = 23.44
                }
            },
            new Book()
            {
                Name = "Вечори на хуторi бiля Диканьки",
                Author = "Микола Гоголь",
                Genre = Genres.Novelette,

                Amount = 2,
                RentCost = new RentCost()
                {
                    CollateralValue = 72.54,
                    RentalPrice = 43.14
                }
            },
            new Book()
            {
                Name = "Кобзар",
                Author = "Тарас Шевченко",
                Genre = Genres.Poetry,

                Amount = 7,
                RentCost = new RentCost()
                {
                    CollateralValue = 59.254,
                    RentalPrice = 33.14
                }
            },
            new Book()
            {
                Name = "Лiсова пiсня",
                Author = "Леся Українка",
                Genre = Genres.Drama,

                Amount = 9,
                RentCost = new RentCost()
                {
                    CollateralValue = 59.254,
                    RentalPrice = 53.14
                }
            },
            new Book()
            {
                Name = "Ворошиловоград",
                Author = "Сергій Жадан",
                Genre = Genres.Novelette,

                Amount = 2,
                RentCost = new RentCost()
                {
                    CollateralValue = 89.254,
                    RentalPrice = 60.14
                }
            },
            new Book()
            {
                Name = "Танго Смерті",
                Author = "Юрій Винничук",
                Genre = Genres.Novelette,

                Amount = 4,
                RentCost = new RentCost()
                {
                    CollateralValue = 49.254,
                    RentalPrice = 20.14
                }
            },
            new Book()
            {
                Name = "Маруся Чурай",
                Author = "Ліна Костенко",
                Genre = Genres.Poetry,

                Amount = 4,
                RentCost = new RentCost()
                {
                    CollateralValue = 70.254,
                    RentalPrice = 49.14
                }
            },
            new Book()
            {
                Name = "Амадока",
                Author = "Софія Андрухович",
                Genre = Genres.Novelette,

                Amount = 6,
                RentCost = new RentCost()
                {
                    CollateralValue = 80.166,
                    RentalPrice = 39.124
                }
            },
            new Book()
            {
                Name = "Тореодори з Васюківки",
                Author = "Всеволод Нестайко",
                Genre = Genres.Novelette,

                Amount = 12,
                RentCost = new RentCost()
                {
                    CollateralValue = 30.166,
                    RentalPrice = 19.024
                }
            },
            new Book()
            {
                Name = "Камінний Хрест",
                Author = "Василь Стефанник",
                Genre = Genres.Novelette,

                Amount = 8,
                RentCost = new RentCost()
                {
                    CollateralValue = 99.166,
                    RentalPrice = 48.334
                }
            },
            new Book()
            {
                Name = "Iнтернат",
                Author = "Сергій Жадан",
                Genre = Genres.Novelette,

                Amount = 5,
                RentCost = new RentCost()
                {
                    CollateralValue =66.354,
                    RentalPrice = 39.14
                }
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
                IsActive = true,
                RentPeriod = new RentPeriod()
                {
                    
                    DateOfIssue = DateTime.Now,
                    ExpectedReturnDate = DateTime.Now.AddMonths(2)
                }
            },
            new Subscription()
            {
                BookId = Books[1].Id,
                ClientId = Clients[2].Id,
                IsActive = true,
                RentPeriod = new RentPeriod()
                {

                    DateOfIssue = DateTime.Now.AddMonths(-1),
                    ExpectedReturnDate = DateTime.Now.AddMonths(2)
                }
            },
            new Subscription()
            {
                BookId = Books[2].Id,
                ClientId = Clients[1].Id,
                IsActive = true,
                RentPeriod = new RentPeriod()
                {

                    DateOfIssue = DateTime.Now.AddMonths(-3),
                    ExpectedReturnDate = DateTime.Now.AddMonths(4)
                }
            },
            new Subscription()
            {
                BookId = Books[1].Id,
                ClientId = Clients[1].Id,
                IsActive = true,
                RentPeriod = new RentPeriod()
                {

                    DateOfIssue = DateTime.Now.AddMonths(-3),
                    ExpectedReturnDate = DateTime.Now.AddMonths(4)
                }
            },
            new Subscription()
            {
                BookId = Books[2].Id,
                ClientId = Clients[3].Id,
                IsActive = true,
                RentPeriod = new RentPeriod()
                {

                    DateOfIssue = DateTime.Now.AddMonths(-3),
                    ExpectedReturnDate = DateTime.Now.AddMonths(-1)
                }
            },
            new Subscription()
            {
                BookId = Books[4].Id,
                ClientId = Clients[6].Id,
                IsActive = true,
                RentPeriod = new RentPeriod()
                {

                    DateOfIssue = DateTime.Now.AddMonths(-3),
                    ExpectedReturnDate = DateTime.Now.AddMonths(2)
                }
            },
            new Subscription()
            {
                BookId = Books[7].Id,
                ClientId = Clients[2].Id,
                IsActive = true,
                RentPeriod = new RentPeriod()
                {

                    DateOfIssue = DateTime.Now.AddMonths(-1),
                    ExpectedReturnDate = DateTime.Now.AddMonths(5)
                }
            }
        };
    }
}

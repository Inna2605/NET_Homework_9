// Для вирішення завдань використовуйте синтаксис запитів LINQ.
//Завдання:
//Реалізуйте користувацький тип «Фірма». В ньому має бути інформація про назву фірми, дату заснування,
//профіль бізнесу (маркетинг, IT, і т. д.), ПІБ директора, кількість працівників, адреса.
//Для масиву фірм реалізуйте такі запити:
// Отримати інформацію про всі фірми.
// Отримати фірми, які мають у назві слово «Food».
// Отримати фірми, які працюють у галузі маркетингу.
// Отримати фірми, які працюють у галузі маркетингу або IT.
// Отримати фірми з кількістю працівників більшою, ніж 100.
// Отримати фірми з кількістю працівників у діапазоні від 100 до 300.
// Отримати фірми, які знаходяться в Лондоні.
// Отримати фірми, в яких прізвище директора Вайт.
// Отримати фірми, які засновані більше двох років тому.
// Отримати фірми з дня заснування яких минуло 123 дні.
// Отримати фірми, в яких прізвище директора Блек і мають у назві фірми слово «White».

using NET_Homework_9;
using System.ComponentModel;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Firm> firms = new List<Firm>
{
    new Firm() {NameFirm = "Авто Фірма", DateEstablishment = "22.11.2000",
        BusinessProfile = "Автосервіс", FullNameDirector = "Кошарук Сергій Дмитрович",
        NumberEmployees = 50, Address = "м. Львів" },
    new Firm() {NameFirm = "Спутник Фірма", DateEstablishment = "03.09.2023",
        BusinessProfile = "Супутникове обладнання", FullNameDirector = "Блек Андрій Віктрович",
        NumberEmployees = 350, Address = "м. Полтава"},
    new Firm() {NameFirm = "Food Фірма", DateEstablishment = "11.05.2022",
        BusinessProfile = "FastFood", FullNameDirector = "Савченко Олександр Ілліч",
        NumberEmployees = 100, Address = "м. Одеса"},
    new Firm() {NameFirm = "White Фірма", DateEstablishment = "09.02.2020",
        BusinessProfile = "Весілля", FullNameDirector = "Блек Орест Миколайович",
        NumberEmployees = 250, Address = "м. Дніпро"},
    new Firm() {NameFirm = "IT Фірма", DateEstablishment = "12.10.2002",
        BusinessProfile = "IT", FullNameDirector = "Никитюк Олександр Сергійович",
        NumberEmployees = 400, Address = "м. Лондон"},
    new Firm() {NameFirm = "Маркетинг Фірма", DateEstablishment = "19.01.2024",
        BusinessProfile = "Маркетинг", FullNameDirector = "Кошарук Сергій Дмитрович",
        NumberEmployees = 300, Address = "м. Вінниця"}
};

Firm[] firmsArray = firms.ToArray();
// Отримати інформацію про всі фірми.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання інформаціїї про всі фірми");
Console.WriteLine("***********************************");
var selectedFirmsArray = from t in firmsArray
                         select t;
foreach (var firm in selectedFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання інформаціїї про всі фірми");
Console.WriteLine("***********************************");
var selectedFirmsArray2 = firmsArray.Select(firm => firm);
foreach (var firm in selectedFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми, які мають у назві слово «Food».
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми, які мають у назві слово «Food»");
Console.WriteLine("***********************************");
var FoodFirmsArray = from t in firmsArray
                     where t.NameFirm.Contains("Food")
                         select t;
foreach (var firm in FoodFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми, які мають у назві слово «Food»");
Console.WriteLine("***********************************");
var FoodFirmsArray2 = firmsArray.Where
    (t => t.NameFirm.Contains("Food"));
foreach (var firm in FoodFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми, які працюють у галузі маркетингу.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми, які працюють у галузі маркетингу");
Console.WriteLine("***********************************");
var MarkFirmsArray = from t in firmsArray
                     where t.BusinessProfile.Contains("Маркетинг")
                     select t;
foreach (var firm in MarkFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми, які працюють у галузі маркетингу");
Console.WriteLine("***********************************");
var MarkFirmsArray2 = firmsArray.Where
    (t => t.BusinessProfile.Contains("Маркетинг"));
foreach (var firm in MarkFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
// Отримати фірми, які працюють у галузі маркетингу або IT.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми, які працюють у галузі маркетингу або IT");
Console.WriteLine("***********************************");
var MarkITFirmsArray = from t in firmsArray
                     where t.BusinessProfile.Contains("Маркетинг") || t.BusinessProfile.Contains("IT")
                     select t;
foreach (var firm in MarkITFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми, які працюють у галузі маркетингу або IT");
Console.WriteLine("***********************************");
var MarkITFirmsArray2 = firmsArray.Where
    (t => t.BusinessProfile.Contains("Маркетинг") || t.BusinessProfile.Contains("IT"));
foreach (var firm in MarkITFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми з кількістю працівників більшою, ніж 100.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми з кількістю працівників більшою, ніж 100");
Console.WriteLine("***********************************");
var CountFirmsArray = from t in firmsArray
                       where t.NumberEmployees > 100
                       orderby t.NumberEmployees
                       select t;
foreach (var firm in CountFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми з кількістю працівників більшою, ніж 100");
Console.WriteLine("***********************************");
var CountFirmsArray2 = firmsArray.Where
    (t => t.NumberEmployees > 100).OrderBy(t=>t);
foreach (var firm in CountFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми з кількістю працівників у діапазоні від 100 до 300.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми з кількістю працівників у діапазоні від 100 до 300");
Console.WriteLine("***********************************");
var Count_FirmsArray = from t in firmsArray
                      where t.NumberEmployees >= 100 && t.NumberEmployees <= 300
                      orderby t.NumberEmployees
                      select t;
foreach (var firm in Count_FirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми з кількістю працівників у діапазоні від 100 до 300");
Console.WriteLine("***********************************");
var Count_FirmsArray2 = firmsArray.Where
    (t => t.NumberEmployees >= 100 && t.NumberEmployees <= 300).OrderBy(t => t);
foreach (var firm in Count_FirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми, які знаходяться в Лондоні.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми, які знаходяться в Лондоні");
Console.WriteLine("***********************************");
var AdressFirmsArray = from t in firmsArray
                       where t.Address.Contains("Лондон")
                       select t;
foreach (var firm in AdressFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми з кількістю працівників у діапазоні від 100 до 300");
Console.WriteLine("***********************************");
var AdressFirmsArray2 = firmsArray.Where
    (t => t.Address.Contains("Лондон"));
foreach (var firm in AdressFirmsArray2)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми, в яких прізвище директора Вайт.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми, в яких прізвище директора Вайт");
Console.WriteLine("***********************************");
var NameFirmsArray = from t in firmsArray
                       where t.FullNameDirector.Contains("Вайт")
                       select t;
foreach (var firm in NameFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми, в яких прізвище директора Вайт");
Console.WriteLine("***********************************");
var NameFirmsArray2 = firmsArray.Where
    (t => t.FullNameDirector.Contains("Вайт"));
foreach (var firm in NameFirmsArray2)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми, які засновані більше двох років тому.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми, які засновані більше двох років тому");
Console.WriteLine("***********************************");
// Отримуємо поточну дату
DateTime currentDate = DateTime.Now;
var DateFirmsArray = from t in firmsArray
                     where (currentDate - DateTime.Parse(t.DateEstablishment)).TotalDays > 365 * 2
                     select t;
foreach (var firm in DateFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми, які засновані більше двох років тому");
Console.WriteLine("***********************************");
var DateFirmsArray2 = firmsArray.Where
    (t => (currentDate - DateTime.Parse(t.DateEstablishment)).TotalDays > 365 * 2);
foreach (var firm in DateFirmsArray2)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми з дня заснування яких минуло 123 дні.
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми з дня заснування яких минуло 123 дні");
Console.WriteLine("***********************************");
var DateFirmsArray123 = from t in firmsArray
                     where (currentDate - DateTime.Parse(t.DateEstablishment)).TotalDays > 123
                     select t;
foreach (var firm in DateFirmsArray123)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми, які засновані більше двох років тому");
Console.WriteLine("***********************************");
var Date2FirmsArray123 = firmsArray.Where
    (t => (currentDate - DateTime.Parse(t.DateEstablishment)).TotalDays > 123);
foreach (var firm in Date2FirmsArray123)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}

// Отримати фірми, в яких прізвище директора Блек і мають у назві фірми слово «White».
//через Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через Linq для отримання фірми, в яких прізвище директора Блек і мають у назві фірми слово «White»");
Console.WriteLine("***********************************");
var WFirmsArray = from t in firmsArray
                        where t.FullNameDirector.Contains("Блек") && t.NameFirm.Contains("White")
                        select t;
foreach (var firm in WFirmsArray)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//через методи розширення Linq
Console.WriteLine("***********************************");
Console.WriteLine("Запит через методи розширення Linq для отримання фірми, які засновані більше двох років тому");
Console.WriteLine("***********************************");
var WFirmsArray2 = firmsArray.Where
    (t => t.FullNameDirector.Contains("Блек") && t.NameFirm.Contains("White"));
foreach (var firm in WFirmsArray2)
{
    Console.WriteLine("Назва фірми: " + firm.NameFirm);
    Console.WriteLine("Дата заснування: " + firm.DateEstablishment);
    Console.WriteLine("Бізнес-профіль: " + firm.BusinessProfile);
    Console.WriteLine("Повне ім'я директора: " + firm.FullNameDirector);
    Console.WriteLine("Кількість співробітників: " + firm.NumberEmployees);
    Console.WriteLine("Адреса: " + firm.Address);
    Console.WriteLine("-----------------------------------");
}
//Для вирішення завдань використовуйте синтаксис запитів LINQ.
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
// Отримати фірми, в яких прізвище директора White.
// Отримати фірми, які засновані більше двох років тому.
// Отримати фірми з дня заснування яких минуло 123 дні.
// Отримати фірми, в яких прізвище директора Black і мають у назві фірми слово «White».

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET_Homework_9
{
    internal class Firm
    {
        public string NameFirm {  get; set; }
        public string DateEstablishment { get; set;}
        public string BusinessProfile { get; set; }
        public string FullNameDirector { get; set; }
        public int NumberEmployees { get; set; }
        public string Address {  get; set; }
        public List<Firm> firms { get; set; }
        public Firm()
        {
            firms = new List<Firm>();
        }
    }
}

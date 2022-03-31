using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1433
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>()
            {
                new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
                new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"),
            };
            Console.WriteLine("Несортированный список:");
            ShowPhoneBook(phoneBook);
            Console.WriteLine();
            var sortedPhoneBook = phoneBook.OrderBy(x => x.Name).ThenBy(x => x.LastName).ToList();
            Console.WriteLine("Сортированный список:");
            ShowPhoneBook(sortedPhoneBook);
        }

        static void ShowPhoneBook(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}

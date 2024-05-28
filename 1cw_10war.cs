using System;
using System.Collections.Generic;

class Contact
{
    private static int uniqueId = 1;
    public int Id { get; }
    public string Name { get; }
    public string Surname { get; }
    public string PhoneNumber { get; }
    public string Email { get; }

    public Contact(string name, string surname, string phoneNumber, string email)
    {
        Id = uniqueId++;
        Name = name;
        Surname = surname;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void DisplayContactInfo()
    {
        Console.WriteLine($"Contact ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Surname: {Surname}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}\n");
    }
}

class Program
{
    static void Main()
    {
        var contacts = new List<Contact>
        {
            new Contact("петя", "поп", "+723456789", "john.doe@example.com"),
            new Contact("маша", "серега", "+8987654321", "alice.seri@example.com"),
            new Contact("боб", "леха", "+555555555", "bob.lexa@example.com"),
            new Contact("мери", "волтер", "+1111222333", "mary.wolter@example.com"),
            new Contact("андрей", "биб", "+444444444", "andr.bib@example.com")
        };

        // Сортировка контактов по фамилии и имени
        contacts.Sort((x, y) =>
        {
            int result = x.Surname.CompareTo(y.Surname);
            if (result == 0)
            {
                result = x.Name.CompareTo(y.Name);
            }
            return result;
        });

        // Вывод контактов в виде таблицы
        Console.WriteLine("ID  | Name   | Surname | Phone Number   | Email");
        Console.WriteLine("--------------------------------------------");
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Id,2}  | {contact.Name,-6} | {contact.Surname,-7} | {contact.PhoneNumber,-14} | {contact.Email}");
        }
    }
}


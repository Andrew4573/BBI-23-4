using System;
using System.Collections.Generic;

public abstract class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
}

public class Employee : Person
{
    public decimal Salary { get; set; }
    public DateTime EmploymentDate { get; set; }

    public Employee(string name, string surname, decimal salary, DateTime employmentDate) : base(name, surname)
    {
        Salary = salary;
        EmploymentDate = employmentDate;
    }
}

public class Counteragent : Person
{
    public decimal ContractCost { get; set; }
    public int ContractDuration { get; set; }

    public Counteragent(string name, string surname, decimal contractCost, int contractDuration) : base(name, surname)
    {
        ContractCost = contractCost;
        ContractDuration = contractDuration;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Иван", "Иванов", 5000, new DateTime(2020, 1, 1)),
            new Employee("Анна", "Петрова", 6000, new DateTime(2019, 5, 15)),
            new Employee("Петр", "Смирнов", 5500, new DateTime(2021, 3, 10)),
            new Employee("Елена", "Козлова", 5200, new DateTime(2018, 8, 20)),
            new Employee("Дмитрий", "Соколов", 5300, new DateTime(2017, 11, 5))
        };

        List<Counteragent> counteragents = new List<Counteragent>()
        {
            new Counteragent("ООО 'Рога и копыта'", "ИНН", 10000, 12),
            new Counteragent("АО 'Солнце'", "ОГРН", 8000, 6),
            new Counteragent("ИП 'Пупкин'", "КПП", 12000, 24),
            new Counteragent("ЗАО 'Ромашка'", "СНИЛС", 9000, 18),
            new Counteragent("НП 'Радуга'", "РНН", 11000, 36)
        };

        employees.Sort((x, y) => x.Surname.CompareTo(y.Surname));
        Console.WriteLine("Сотрудники:");
        Console.WriteLine("Имя \t\t Фамилия \t Зарплата \t Дата Трудоустройства");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} \t {employee.Surname} \t {employee.Salary} \t {employee.EmploymentDate.ToShortDateString()}");
        }

        counteragents.Sort((x, y) => x.Surname.CompareTo(y.Surname));
        Console.WriteLine("\nКонтрагенты:");
        Console.WriteLine("Имя \t\t Фамилия \t Стоимость Договора \t Срок Договора");
        foreach (Counteragent counteragent in counteragents)
        {
            Console.WriteLine($"{counteragent.Name} \t {counteragent.Surname} \t {counteragent.ContractCost} \t\t {counteragent.ContractDuration}");
        }

        List<Person> people = new List<Person>();
        people.AddRange(employees);
        people.AddRange(counteragents);

        people.Sort((x, y) => x.Surname.CompareTo(y.Surname));
        Console.WriteLine("\nВсе Люди:");
        Console.WriteLine("Имя \t\t Фамилия");
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} \t {person.Surname}");
        }
    }
}

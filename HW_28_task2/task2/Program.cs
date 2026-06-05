using HW_28_task2.task2;

namespace HW_28_task2;

class Program
{
    static void Main()
    {
        Employee[] employees =
        {
            new Employee("Kuchiki ", "Rukia", 1995, 70000),
            new Employee("Zaraki", "Kenpachi", 1998, 85000),
            new Employee("Aizen", "Sosuke", 1990, 60000),
            new Employee("Unohana", "Retsu", 2000, 190000)
        };
        
        EmployeeCollection collection = new EmployeeCollection(employees);
        foreach (Employee employee in collection)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}, {employee.BirthYear}, {employee.Salary}");
        }
    }
}
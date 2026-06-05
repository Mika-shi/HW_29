using HW_28.task_1.comparer;

namespace HW_28.task_1;

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Ichimaru", "Gin", 1980, 10000),
            new Employee("Kurotsuchi ", "Mayuri", 1760, 85000),
            new Employee("Grimmjow", "Jaegerjaques", 1870, 120000),
            new Employee("Urahara", "Kisuke", 1880, 150000),
        };
        employees.Sort(new FirstNameComparer());
        PrintEmployees("Sorted by first name: ", employees);
        
        employees.Sort(new LastNameComparer());
        PrintEmployees("Sorted by last name : ", employees);

        employees.Sort(new BirthdayComparer());
        PrintEmployees("Sorted by birth Year  : ", employees);
        
        employees.Sort(new SalaryComparer());
        PrintEmployees("Sorted by salary     : ", employees);
    }
    
    static void PrintEmployees(string message, List<Employee> employees)
    {
        Console.WriteLine(message);
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee);
        }
        Console.WriteLine();
    }
}
using System.Collections;
namespace HW_28_task2.task2;

public class EmployeeCollection : IEnumerable
{
    private Employee[] _employees;

    public EmployeeCollection(Employee[] employees)
    {
        _employees = employees;
    }

    public IEnumerator GetEnumerator()
    {
        return new EmployeeCollectionEnumerator(_employees);
    }
}
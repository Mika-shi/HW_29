using System.Collections;

namespace HW_28_task2.task2;

public class EmployeeCollectionEnumerator : IEnumerator
{
    private Employee[] _employees;
    private int _index = -1;

    public EmployeeCollectionEnumerator(Employee[] employees)
    {
        _employees = employees;
    }

    public object Current
    {
        get { return _employees[_index]; }
    }

    public bool MoveNext()
    {
        _index++;
        return _index < _employees.Length;
    }

    public void Reset()
    {
        _index = -1;
    }
}
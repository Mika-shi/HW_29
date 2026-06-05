namespace HW_28.task_1.comparer;

public class LastNameComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return string.Compare(x?.LastName, y?.LastName);
    }
}
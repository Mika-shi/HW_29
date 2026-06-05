namespace HW_28.task_1.comparer;

public class SalaryComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        if (x == null && y == null)
            return 0;

        if (x == null)
            return -1;

        if (y == null)
            return 1;

        return x.BirthYear.CompareTo(y.BirthYear);
    }
}
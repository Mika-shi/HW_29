namespace HW_28.task_1.comparer;

public class BirthdayComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return x.BirthYear.CompareTo(y.BirthYear);
    }
}
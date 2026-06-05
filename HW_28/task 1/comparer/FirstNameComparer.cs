namespace HW_28.task_1.comparer;

public class FirstNameComparer : IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return string.Compare(x?.FirstName, y?.FirstName);
    }
    
}
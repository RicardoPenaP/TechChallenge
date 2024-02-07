namespace Company.Employees
{
    public abstract class EmployeesProperty
    {
        public abstract T ReadPropertyValue<T>();

        public abstract override string ToString();
    }
}

using System;

namespace Company.Employees.EmployeesProperties
{
    public class EmployeesAmount : EmployeesProperty
    {
        private int value;

        public EmployeesAmount(int value)
        {
            this.value = value;
        }

        public override T ReadPropertyValue<T>()
        {
            if (typeof(T) == typeof(int))
            {                
                return (T)(object)value;
            }
            else
            {                
                throw new InvalidOperationException($"Cannot convert value from int to {typeof(T)}");
            }
        }
    }
}

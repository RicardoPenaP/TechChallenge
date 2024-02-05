using System;

namespace Company.Employees.EmployeesProperties
{
    public class BaseSalary : EmployeesProperty
    {
        private float value;

        public BaseSalary(float value)
        {
            this.value = value;
        }

        public override T ReadPropertyValue<T>()
        {
            if (typeof(T) == typeof(float))
            {
                return (T)(object)value;
            }
            else
            {
                throw new InvalidOperationException($"Cannot convert value from float to {typeof(T)}");
            }
        }
    }
}

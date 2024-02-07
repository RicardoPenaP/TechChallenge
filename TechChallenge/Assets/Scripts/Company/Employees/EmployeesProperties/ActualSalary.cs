using System;

namespace Company.Employees.EmployeesProperties
{
    public class ActualSalary : EmployeesProperty
    {
        private float value;

        public ActualSalary(float value)
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

        public override string ToString()
        {
            return $"{value}$";
        }
    }
}

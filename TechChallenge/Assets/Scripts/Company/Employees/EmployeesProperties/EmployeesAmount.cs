using System;

namespace Company.Employees.EmployeesProperties
{
    public class EmployeesAmount : EmployeesProperty
    {
        private int amount;

        public EmployeesAmount(int amount)
        {
            this.amount = amount;
        }

        public override T ReadPropertyValue<T>()
        {
            if (typeof(T) == typeof(int))
            {                
                return (T)(object)amount;
            }
            else
            {                
                throw new InvalidOperationException($"Cannot convert value from int to {typeof(T)}");
            }
        }
    }
}

using Company.Interfaces;

namespace Company.EmployeesInformation
{
    public class EmployeesAmount : IEmployeeProperty<int>
    {
        private int amount;

        public EmployeesAmount(int amount)
        {
            this.amount = amount;
        }

        public int GetPropertyValue()
        {
            return amount;
        }

    }
}

using Company.Enums;

namespace Company.Employees
{
    public class EmployeesInformation 
    {        
        private int employeesAmount;
        
        public int EmployeesAmount { get { return employeesAmount; } }

        public EmployeesInformation()
        {           
            employeesAmount = 0;
        }

        public EmployeesInformation(int employeesAmount)
        {
            this.employeesAmount = employeesAmount;
        }

    }
}

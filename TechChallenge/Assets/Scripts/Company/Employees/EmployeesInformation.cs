namespace Company.Employees
{
    public class EmployeesInformation 
    {        
        private int employeesAmount;
        private float salaryIncrementPercentage;
        
        public int EmployeesAmount { get { return employeesAmount; } }
        public float SalaryIncrementPercentage { get { return salaryIncrementPercentage; } }

        public EmployeesInformation()
        {           
            employeesAmount = 0;
            salaryIncrementPercentage = 0;
        }

        public EmployeesInformation(int employeesAmount,float salaryIncrementPercentage)
        {
            this.employeesAmount = employeesAmount;
            this.salaryIncrementPercentage = salaryIncrementPercentage;
        }

    }
}

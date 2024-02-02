namespace Company.Employees
{
    public class EmployeesInformation
    {
        private int employeesAmount;
        private float salaryIncrementPercentage;
        private int salaryAmount;

        public int EmployeesAmount { get { return employeesAmount; } }
        public float SalaryIncrementPercentage { get { return salaryIncrementPercentage; } }

        public EmployeesInformation()
        {
            employeesAmount = 0;
            salaryIncrementPercentage = 0;
            salaryAmount = 0;
        }

        public EmployeesInformation(int employeesAmount, float salaryIncrementPercentage, int salaryAmount)
        {
            this.employeesAmount = employeesAmount;
            this.salaryIncrementPercentage = salaryIncrementPercentage;
            this.salaryAmount = salaryAmount;
        }
    }
}

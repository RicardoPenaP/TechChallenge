namespace CompanyMVC.CompanyView
{
    public class CompanyViewUpdateData 
    {
        private string sectionName;
        private string seniorityLevel;
        private string employeesAmount;
        private string salaryIncrementPercentage;
        private string baseSalary;
        private string actualSalary;

        public string SectionName => sectionName;
        public string SeniorityLevel => seniorityLevel;
        public string EmployeesAmount => employeesAmount;
        public string SalaryincrementPercentage => salaryIncrementPercentage;
        public string BaseSalary => baseSalary;
        public string ActualSalary => actualSalary;        

        public CompanyViewUpdateData(string sectionName, string seniorityLevel, string employeesAmount, string salaryIncrementPercentage, string baseSalary, string actualSalary)
        {
            this.sectionName = sectionName;
            this.seniorityLevel = seniorityLevel;
            this.employeesAmount = employeesAmount;
            this.salaryIncrementPercentage = salaryIncrementPercentage;
            this.baseSalary = baseSalary;
            this.actualSalary = actualSalary;
        }
    }
}

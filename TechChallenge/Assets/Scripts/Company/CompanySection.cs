using Company.Employees;
using Company.Employees.EmployeesProperties;
using Company.Enums;
using System.Collections.Generic;
using Tools.Calculators;

namespace Company
{
    public class CompanySection
    {
        private Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployeesDictionary;

        public CompanySection()
        {
            sectionEmployeesDictionary = new Dictionary<SeniorityLevels, EmployeesInformation>();
        }

        public void SetSectionEmployeesDictionary(Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployeesDictionary)
        {
            this.sectionEmployeesDictionary = sectionEmployeesDictionary;
        }

        public Dictionary<SeniorityLevels, EmployeesInformation> GetSectionEmployeesDictionary()
        {
            return sectionEmployeesDictionary;
        }

        public void IncreaseSectionEmployeesSalaries()
        {
            foreach (KeyValuePair<SeniorityLevels, EmployeesInformation> keyValuePair in sectionEmployeesDictionary)
            {
                float actuaSalaryValue = 0;
                ActualSalary actualSalary = keyValuePair.Value.GetEmployeesProperty<ActualSalary>();

                if (actualSalary != null)
                {
                    actuaSalaryValue = actualSalary.ReadPropertyValue<float>();
                }
                else
                {
                    actuaSalaryValue = keyValuePair.Value.GetEmployeesProperty<BaseSalary>().ReadPropertyValue<float>();
                }

                float salaryAugmentPercentage = keyValuePair.Value.GetEmployeesProperty<SalaryIncrementPercentage>().ReadPropertyValue<float>();

                float newSalaryAmount = SalaryCalculator.CalculateSalaryIncrease(salaryAugmentPercentage, actuaSalaryValue);
                keyValuePair.Value.OverrideEmployeesProperty<ActualSalary>(new ActualSalary(newSalaryAmount));                
            }
        }
    }
}

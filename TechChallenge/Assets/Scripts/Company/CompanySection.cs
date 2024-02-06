using Company.Employees;
using Company.Employees.EmployeesProperties;
using Company.Enums;
using System.Collections.Generic;
using Tools.Calculators;

namespace Company
{
    public class CompanySection
    {
        private string sectionName;
        private List<EmployeesInformation> employeesInformationList;        

        public CompanySection()
        {
            employeesInformationList = new List<EmployeesInformation>();
        }

        public void SetEmployeesInformationList(List<EmployeesInformation> employeesInformationList)
        {
            this.employeesInformationList = employeesInformationList;
        }

        public List<EmployeesInformation> GetEmployeesInformationList()
        {
            return employeesInformationList;
        }

        public EmployeesInformation GetEmployeesInformationBySeniorityLevel(SeniorityLevels seniorityLevel)
        {
            foreach (EmployeesInformation employeesInformation in employeesInformationList)
            {
                EmployeesSeniorityLevel employeesSeniorityLevel = employeesInformation.GetEmployeesProperty<EmployeesSeniorityLevel>();
                if (employeesSeniorityLevel != null)
                {
                    if (employeesSeniorityLevel.ReadPropertyValue<SeniorityLevels>() == seniorityLevel)
                    {
                        return employeesInformation;
                    }
                }
            }
            return null;
        }

        public void IncreaseSectionEmployeesSalaries()
        {
            foreach (EmployeesInformation employeesInformation in employeesInformationList)
            {
                float actuaSalaryValue = 0;
                ActualSalary actualSalary = employeesInformation.GetEmployeesProperty<ActualSalary>();

                if (actualSalary != null)
                {
                    actuaSalaryValue = actualSalary.ReadPropertyValue<float>();
                }
                else
                {
                    actuaSalaryValue = employeesInformation.GetEmployeesProperty<BaseSalary>().ReadPropertyValue<float>();
                }

                float salaryAugmentPercentage = employeesInformation.GetEmployeesProperty<SalaryIncrementPercentage>().ReadPropertyValue<float>();
                float newSalaryAmount = SalaryCalculator.CalculateSalaryIncrease(salaryAugmentPercentage, actuaSalaryValue);
                employeesInformation.OverrideEmployeesProperty(new ActualSalary(newSalaryAmount));
            }
        }

        public void SetSectionName(string sectionName)
        {
            this.sectionName = sectionName;
        }

        public string GetSectionName()
        {
            return sectionName;
        }
        
    }
}

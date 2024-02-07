using Company;
using Company.Employees;
using Company.Employees.EmployeesProperties;
using Company.Enums;
using MVC.Models.ModelsData;
using System.Collections.Generic;

namespace MVC.DataFormatters
{
    public static class ModelDataFormatter 
    {        
        public static List<EmployeesInformation> FormatCompanySectionDataToEmployeesInformationList(CompanySectionData companySectionData)
        {
            List<EmployeesInformation> employeesInformationList = new List<EmployeesInformation>();

            for (int i = 0; i < companySectionData.SeniorityLevels.Length; i++)
            {
                List<EmployeesProperty> employeesProperties = CreateEmployeesPropertiesList(
                    companySectionData.SeniorityLevels[i], companySectionData.EmployeesAmount[i],
                    companySectionData.SalaryIncrementPercentage[i], companySectionData.BaseSalary[i]);

                EmployeesInformation newEmployeesInformation = new EmployeesInformation();
                newEmployeesInformation.SetEmployeesPropeties(employeesProperties);
                employeesInformationList.Add(newEmployeesInformation);
            }
            return employeesInformationList;
        }

        private static List<EmployeesProperty> CreateEmployeesPropertiesList(SeniorityLevels seniorityLevel, int employeesAmount, float salaryIncrementPercentage, float baseSalary)
        {
            List<EmployeesProperty> employeesProperties = new List<EmployeesProperty>();
            employeesProperties.Add(new EmployeesSeniorityLevel(seniorityLevel));
            employeesProperties.Add(new EmployeesAmount(employeesAmount));
            employeesProperties.Add(new SalaryIncrementPercentage(salaryIncrementPercentage));
            employeesProperties.Add(new BaseSalary(baseSalary));
            employeesProperties.Add(new ActualSalary(baseSalary));

            return employeesProperties;
        }


    }
}

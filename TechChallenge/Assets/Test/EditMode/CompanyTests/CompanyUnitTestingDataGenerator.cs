using Company;
using Company.Employees;
using Company.Employees.EmployeesProperties;
using Company.Enums;
using System.Collections.Generic;

namespace EditMode.CompanyTests
{
    public static class CompanyUnitTestingDataGenerator
    {
        public static int[] GenerateCompanySectionEmployeesAmountArrayForTesting(int[] startingValues, SeniorityLevels[] seniorityLevels)
        {
            int arraysLenght = startingValues.Length;

            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new EmployeesAmount(startingValues[i]));
                sectionEmployees.Add(seniorityLevels[i], employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            int[] targetAmounts = new int[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = targetEmployees[seniorityLevels[i]].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            }

            return targetAmounts;
        }

        public static float[] GenerateCompanySalaryIncrementArrayForTesting(float[] startingValues, SeniorityLevels[] seniorityLevels)
        {
            int arraysLenght = startingValues.Length;

            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new SalaryIncrementPercentage(startingValues[i]));
                sectionEmployees.Add(seniorityLevels[i], employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            float[] targetAmounts = new float[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = targetEmployees[seniorityLevels[i]].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<float>();
            }

            return targetAmounts;
        }

        public static float[] GenerateCompanyBaseSalaryArrayForTesting(float[] startingValues, SeniorityLevels[] seniorityLevels)
        {   
            int arraysLenght = startingValues.Length;

            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new SalaryIncrementPercentage(startingValues[i]));
                sectionEmployees.Add(seniorityLevels[i], employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            float[] targetAmounts = new float[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = targetEmployees[seniorityLevels[i]].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<float>();
            }

            return targetAmounts;
        }

        public static float[] GenerateCompanyIncrementedSalaryArrayForTesting(float[] baseSalariesValues,float[] incrementPercentages, SeniorityLevels[] seniorityLevels)
        {
            int arraysLenght = baseSalariesValues.Length;

            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new BaseSalary(baseSalariesValues[i]));
                employeesInformation.AddEmployeesProperty(new SalaryIncrementPercentage(incrementPercentages[i]));
                sectionEmployees.Add(seniorityLevels[i], employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            float[] targetAmounts = new float[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = targetEmployees[seniorityLevels[i]].GetEmployeesProperty<BaseSalary>().ReadPropertyValue<float>();
            }

            return targetAmounts;
        }
    }
}

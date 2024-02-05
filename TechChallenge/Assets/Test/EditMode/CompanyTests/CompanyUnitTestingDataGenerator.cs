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

            List<EmployeesInformation> sectionEmployeesList = new List<EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new EmployeesSeniorityLevel(seniorityLevels[i]));
                employeesInformation.AddEmployeesProperty(new EmployeesAmount(startingValues[i]));
                sectionEmployeesList.Add(employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetEmployeesInformationList(sectionEmployeesList);

            int[] targetAmounts = new int[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = companySection.GetEmployeesInformationBySeniorityLevel(seniorityLevels[i]).
                                   GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            }

            return targetAmounts;
        }

        public static float[] GenerateCompanySalaryIncrementArrayForTesting(float[] startingValues, SeniorityLevels[] seniorityLevels)
        {
            int arraysLenght = startingValues.Length;

            List<EmployeesInformation> sectionEmployeesList = new List<EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new EmployeesSeniorityLevel(seniorityLevels[i]));
                employeesInformation.AddEmployeesProperty(new SalaryIncrementPercentage(startingValues[i]));
                sectionEmployeesList.Add(employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetEmployeesInformationList(sectionEmployeesList);

            float[] targetAmounts = new float[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = companySection.GetEmployeesInformationBySeniorityLevel(seniorityLevels[i]).
                                   GetEmployeesProperty<SalaryIncrementPercentage>().ReadPropertyValue<float>();
            }

            return targetAmounts;
        }

        public static float[] GenerateCompanyBaseSalaryArrayForTesting(float[] startingValues, SeniorityLevels[] seniorityLevels)
        {
            int arraysLenght = startingValues.Length;

            List<EmployeesInformation> sectionEmployeesList = new List<EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new EmployeesSeniorityLevel(seniorityLevels[i]));
                employeesInformation.AddEmployeesProperty(new BaseSalary(startingValues[i]));
                sectionEmployeesList.Add(employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetEmployeesInformationList(sectionEmployeesList);

            float[] targetAmounts = new float[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = companySection.GetEmployeesInformationBySeniorityLevel(seniorityLevels[i]).
                                   GetEmployeesProperty<BaseSalary>().ReadPropertyValue<float>();
            }

            return targetAmounts;
        }

        public static float[] GenerateCompanyIncrementedSalaryArrayForTesting(float[] baseSalariesValues, float[] incrementPercentages, SeniorityLevels[] seniorityLevels)
        {
            int arraysLenght = baseSalariesValues.Length;

            List<EmployeesInformation> sectionEmployeesList = new List<EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new EmployeesSeniorityLevel(seniorityLevels[i]));
                employeesInformation.AddEmployeesProperty(new BaseSalary(baseSalariesValues[i]));
                employeesInformation.AddEmployeesProperty(new SalaryIncrementPercentage(incrementPercentages[i]));
                employeesInformation.AddEmployeesProperty(new ActualSalary(baseSalariesValues[i]));
                sectionEmployeesList.Add(employeesInformation);               
            }

            CompanySection companySection = new CompanySection();
            companySection.SetEmployeesInformationList(sectionEmployeesList);
            companySection.IncreaseSectionEmployeesSalaries();

            float[] targetAmounts = new float[arraysLenght];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = companySection.GetEmployeesInformationBySeniorityLevel(seniorityLevels[i]).
                                   GetEmployeesProperty<ActualSalary>().ReadPropertyValue<float>();
            }

            return targetAmounts;
        }
    }
}

using Company;
using Company.Employees;
using MVC.Views.ViewsData;
using System.Collections.Generic;
using Company.Employees.EmployeesProperties;
using UnityEngine;

namespace MVC.DataFormatters
{
    public static class ControllerDataFormatter
    {
        public static CompanyInformationViewData FormatCompanyInformationToCompanyInformationViewData(CompanyInformation companyInformation)
        {
            List<CompanySection> companySections = companyInformation.GetCompanySectionsList();
            int companySectionsAmount = companySections.Count;

            SectionInformationViewData[] sectionInformationViewDataArray = new SectionInformationViewData[companySectionsAmount];


            for (int i = 0; i < companySectionsAmount; i++)
            {
                string sectionName = companySections[i].GetSectionName();
                List<EmployeesInformation> employeesInformation = companySections[i].GetEmployeesInformationList();
                int propertiesAmount = employeesInformation.Count;

                string[] seniorityLevelsArray = new string[propertiesAmount];
                string[] employeesAmountsArray = new string[propertiesAmount];
                string[] salaryIncrementPercentagesArray = new string[propertiesAmount];
                string[] baseSalariesArray = new string[propertiesAmount];
                string[] actualSalariesArray = new string[propertiesAmount];

                for (int j = 0; j < propertiesAmount; j++)
                {
                    seniorityLevelsArray[j] = employeesInformation[j].GetEmployeesProperty<EmployeesSeniorityLevel>().ToString();
                    employeesAmountsArray[j] = employeesInformation[j].GetEmployeesProperty<EmployeesAmount>().ToString();
                    salaryIncrementPercentagesArray[j] = employeesInformation[j].GetEmployeesProperty<SalaryIncrementPercentage>().ToString();
                    baseSalariesArray[j] = employeesInformation[j].GetEmployeesProperty<BaseSalary>().ToString();
                    actualSalariesArray[j] = employeesInformation[j].GetEmployeesProperty<ActualSalary>().ToString();
                }

                SectionInformationViewData newSectionInformationViewData = new SectionInformationViewData(sectionName,
                                                                               seniorityLevelsArray, employeesAmountsArray,
                                                                               salaryIncrementPercentagesArray, baseSalariesArray,
                                                                               actualSalariesArray);


                sectionInformationViewDataArray[i] = newSectionInformationViewData;
            }

            return new CompanyInformationViewData(companyInformation.CompanyName, sectionInformationViewDataArray);
        }

        public static ActualSalaryViewUpdateData[] FormatCompanySectionsToActualSalaryViewUpdateData(List<CompanySection> companySections)
        {
            ActualSalaryViewUpdateData[] sectionsSalaryViewUpdateDataArray = new ActualSalaryViewUpdateData[companySections.Count];

            for (int i = 0; i < sectionsSalaryViewUpdateDataArray.Length; i++)
            {
                string sectionName = companySections[i].GetSectionName();

                List<EmployeesInformation> employeesInformation = companySections[i].GetEmployeesInformationList();
                string[] actualSalariesText = new string[employeesInformation.Count];

                for (int j = 0; j < actualSalariesText.Length; j++)
                {
                    actualSalariesText[j] = employeesInformation[j].GetEmployeesProperty<ActualSalary>().ToString();
                }

                ActualSalaryViewUpdateData newActualSalaryViewUpdateData = new ActualSalaryViewUpdateData(sectionName, actualSalariesText);
                sectionsSalaryViewUpdateDataArray[i] = newActualSalaryViewUpdateData;
            }

            return sectionsSalaryViewUpdateDataArray;
        }
    }
}

using Company;
using Company.Employees;
using Company.Employees.EmployeesProperties;
using Company.Enums;
using CompanyMVC.CompanyModel.ModelData;
using System.Collections.Generic;
using UnityEngine;

namespace CompanyMVC.Factories
{
    public class CompanyModelFactory : MonoBehaviour
    {
        [Header("Company Model Factory")]
        [SerializeField] private CompanyModelData techChallengeCompanyModelData;

        public CompanyInformation CreateNewCompany()
        {
            List<CompanySection> companySections = new List<CompanySection>();

            for (int i = 0; i < techChallengeCompanyModelData.CompanySections.Length; i++)
            {                            
                companySections[i] = new CompanySection();
                companySections[i].SetSectionName(techChallengeCompanyModelData.CompanySections[i].CompanySectionName);
                List<EmployeesInformation> employeesInformationList = GetEmployeesInformationList(techChallengeCompanyModelData.CompanySections[i]);

                companySections[i].SetEmployeesInformationList(employeesInformationList);
            }

            return new CompanyInformation(techChallengeCompanyModelData.CompanyName, companySections);
        }

        private List<EmployeesInformation> GetEmployeesInformationList(CompanySectionData companySectionData)
        {
            List<EmployeesInformation> employeesInformationList = new List<EmployeesInformation>();

            for (int i = 0; i < companySectionData.SeniorityLevels.Length; i++)
            {
                List<EmployeesProperty> employeesProperties = GetSectionEmployeesPropertiesList(
                    companySectionData.SeniorityLevels[i],companySectionData.EmployeesAmount[i],
                    companySectionData.SalaryIncrementPercentage[i], companySectionData.BaseSalary[i]);

                EmployeesInformation newEmployeesInformation = new EmployeesInformation();
                newEmployeesInformation.SetEmployeesPropeties(employeesProperties);
                employeesInformationList.Add(newEmployeesInformation);
            }
            return employeesInformationList; 
        }

        private List<EmployeesProperty> GetSectionEmployeesPropertiesList(SeniorityLevels seniorityLevel, int employeesAmount, float salaryIncrementPercentage, float baseSalary)
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

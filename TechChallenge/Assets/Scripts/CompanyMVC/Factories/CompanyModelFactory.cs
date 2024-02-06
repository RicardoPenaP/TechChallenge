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
                string sectionName = GetSectionName(i);                
                companySections[i] = new CompanySection();


                List<EmployeesProperty> employeesPropertiesList = GetSectionEmployeesPropertiesList(techChallengeCompanyModelData.CompanySections[i]);


               
            }

            return new CompanyInformation(techChallengeCompanyModelData.CompanyName, companySections);
        }

        private string GetSectionName(int index)
        {
            return techChallengeCompanyModelData.CompanySections[index].CompanySectionName;
        }

        private List<EmployeesProperty> GetSectionEmployeesPropertiesList(CompanySectionData companySectionData)
        {
            List<EmployeesProperty> employeesPropertiesList = new List<EmployeesProperty>();

            return employeesPropertiesList;
        }
    }
}

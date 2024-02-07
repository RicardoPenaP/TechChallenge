using Company;
using Company.Employees;
using MVC.Models.ModelsData;
using MVC.DataFormatters;
using System.Collections.Generic;
using UnityEngine;


namespace MVC.Factories
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
                CompanySection newCompanySection = new CompanySection();
                newCompanySection.SetSectionName(techChallengeCompanyModelData.CompanySections[i].CompanySectionName);
                List<EmployeesInformation> employeesInformationList = ModelDataFormatter.FormatCompanySectionDataToEmployeesInformationList(techChallengeCompanyModelData.CompanySections[i]);
                newCompanySection.SetEmployeesInformationList(employeesInformationList);
                companySections.Add(newCompanySection);
            }

            return new CompanyInformation(techChallengeCompanyModelData.CompanyName, companySections);
        }


    }
}

using Company;
using Company.Employees;
using CompanyMVC.CompanyModel.ModelData;
using CompanyMVC.DataFormatters;
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
                List<EmployeesInformation> employeesInformationList = ModelDataFormatter.FormatCompanySectionDataToEmployeesInformationList(techChallengeCompanyModelData.CompanySections[i]);

                companySections[i].SetEmployeesInformationList(employeesInformationList);
            }

            return new CompanyInformation(techChallengeCompanyModelData.CompanyName, companySections);
        }


    }
}

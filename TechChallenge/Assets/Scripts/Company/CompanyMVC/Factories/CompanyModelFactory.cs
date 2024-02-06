using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.CompanyMVC.CompanyModel.ModelData;
using Company.Employees;
using Company;

namespace Company.CompanyMVC.Factories
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
                //companySections[i] = new CompanySection();
                //List<EmployeesProperty> employeesPropertiesList = new List<EmployeesProperty>();
                

                //companySections[i].SetEmployeesInformationList();
            }

            return new CompanyInformation(techChallengeCompanyModelData.CompanyName, companySections);
        }
    }
}

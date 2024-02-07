using UnityEngine;
using CompanyMVC.Factories;
using Company;

namespace CompanyMVC.CompanyModel
{
    public class CompanyModel : MonoBehaviour
    {
        [Header("Company Model")]
        [Header("Runtime References")]
        [SerializeField] private CompanyModelFactory companyModelFactory;

        private CompanyInformation companyInformation;

        private void Awake()
        {
            companyInformation = companyModelFactory.CreateNewCompany();
        }


    }
}

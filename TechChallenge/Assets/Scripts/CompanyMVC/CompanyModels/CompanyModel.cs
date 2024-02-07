using UnityEngine;
using MVC.Factories;
using Company;

namespace MVC.Models
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

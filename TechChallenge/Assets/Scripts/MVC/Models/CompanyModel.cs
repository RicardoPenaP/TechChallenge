using UnityEngine;
using MVC.Factories;
using Company;
using System;

namespace MVC.Models
{
    public class CompanyModel : MonoBehaviour
    {
        [Header("Company Model")]
        [Header("Runtime References")]
        [SerializeField] private CompanyModelFactory companyModelFactory;
                
        public event Action<CompanyInformation> OnCompanyInformationUpdated;
        public event Action OnSalariesIncreased;

        private CompanyInformation companyInformation;

        private void Start()
        {
            companyInformation = companyModelFactory.CreateNewCompany();
            OnCompanyInformationUpdated?.Invoke(companyInformation);
        }

        public void IncreaseCompanySalaries()
        {
            companyInformation.IncreaseCompanySalaires();
            OnSalariesIncreased?.Invoke();
        }


    }
}

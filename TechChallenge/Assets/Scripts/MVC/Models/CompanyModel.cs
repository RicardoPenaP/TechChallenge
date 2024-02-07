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

        public event Action<CompanyInformation> OnIncreasedCompanySalaries;

        private CompanyInformation companyInformation;

        private void Awake()
        {
            companyInformation = companyModelFactory.CreateNewCompany();
        }

        public void IncreaseCompanySalaries()
        {
            companyInformation.IncreaseCompanySalaires();
            OnIncreasedCompanySalaries?.Invoke(companyInformation);
        }


    }
}

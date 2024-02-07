using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC.Views;
using MVC.Models;
using Company;

namespace MVC.Controllers
{
    public class CompanyController : MonoBehaviour
    {
        [Header("Company Controller")]
        [SerializeField] private CompanyView companyView;
        [SerializeField] private CompanyModel companyModel;

        private void Awake()
        {
            companyView.OnIncrementSalariesButtonPressed += CompanyView_OnIncrementSalariesButtonPressed;
            companyModel.OnCompanyInformationUpdated += CompanyModel_OnCompanyInformationUpdated;
        }


        private void OnDestroy()
        {
            companyView.OnIncrementSalariesButtonPressed -= CompanyView_OnIncrementSalariesButtonPressed;
        }

        private void CompanyView_OnIncrementSalariesButtonPressed()
        {
            companyModel.IncreaseCompanySalaries();
        }

        private void CompanyModel_OnCompanyInformationUpdated(CompanyInformation companyInformation)
        {
            //companyView.
        }
    }
}

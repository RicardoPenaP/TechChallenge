using Company;
using MVC.Models;
using MVC.Views;
using MVC.Views.ViewsData;
using UnityEngine;
using MVC.DataFormatters;

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
            CompanyInformationViewData companyInformationViewData = ControllerDataFormatter.FormatCompanyInformationToCompanyInformationViewData(companyInformation);
            companyView.InitializeCompanySectionInformationPanels(companyInformationViewData);
        }
    }
}

using Company;
using MVC.DataFormatters;
using MVC.Models;
using MVC.Views;
using MVC.Views.ViewsData;
using System.Collections.Generic;
using UnityEngine;

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
            companyModel.OnSalariesIncreased += CompanyModel_OnSalariesIncreased;
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
        private void CompanyModel_OnSalariesIncreased(List<CompanySection> companySections)
        {
            ActualSalaryViewUpdateData[] sectionsActualSalaryViewUpdateDatas = ControllerDataFormatter.FormatCompanySectionsToActualSalaryViewUpdateData(companySections);
            companyView.UpdatedActualSalaries(sectionsActualSalaryViewUpdateDatas);
        }
    }
}

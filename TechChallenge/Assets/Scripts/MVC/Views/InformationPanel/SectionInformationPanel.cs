using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MVC.Views.ViewsData;

namespace MVC.Views.InformationPanel
{
    public class SectionInformationPanel : MonoBehaviour
    {
        [Header("Section Information Panel")]
        [SerializeField] private TextMeshProUGUI sectionNameText;
        [SerializeField] private PropertyInformationVerticalLayout seniorityLayout;
        [SerializeField] private PropertyInformationVerticalLayout employeesAmountLayout;
        [SerializeField] private PropertyInformationVerticalLayout salaryIncrementPercentageLayout;
        [SerializeField] private PropertyInformationVerticalLayout baseSalaryLayout;
        [SerializeField] private PropertyInformationVerticalLayout actualSalaryLayout;

        public string SectionName => sectionNameText.text;

        public void InitializeSectionInformationPanel(SectionInformationViewData sectionInformationViewData)
        {
            sectionNameText.text = sectionInformationViewData.SectionName;
            seniorityLayout.SetPropertiesInformationText(sectionInformationViewData.SeniorityLevelsArray);
            employeesAmountLayout.SetPropertiesInformationText(sectionInformationViewData.EmployeesAmountArray);
            salaryIncrementPercentageLayout.SetPropertiesInformationText(sectionInformationViewData.SalaryIncrementPercentagesArray);
            baseSalaryLayout.SetPropertiesInformationText(sectionInformationViewData.BaseSalariesArray);
            actualSalaryLayout.SetPropertiesInformationText(sectionInformationViewData.ActualSalariesArray);
        }

        public void UpdateActualSalaryLayout(string[] actualSalariesArray)
        {
            actualSalaryLayout.SetPropertiesInformationText(actualSalariesArray);
        }


    }
}

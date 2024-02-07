using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

        //public void InitializeSectionInformationPanel(string sectionName, string[]seniorityTexts, string[] employeesAmountTexts, string)


    }
}

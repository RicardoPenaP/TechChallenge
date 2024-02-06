using TMPro;
using UnityEngine;

namespace CompanyMVC.CompanyView.InformationPanel
{
    public class SectionInformationPropertiesView : MonoBehaviour
    {
        [Header("Section Information Properties View")]
        [SerializeField] private TextMeshProUGUI sectionNameText;
        [SerializeField] private TextMeshProUGUI seniorityLevelText;
        [SerializeField] private TextMeshProUGUI employeesAmountText;
        [SerializeField] private TextMeshProUGUI salaryIncrementPercentageText;
        [SerializeField] private TextMeshProUGUI baseSalaryText;
        [SerializeField] private TextMeshProUGUI actualSalaryText;

        public void ClearAllPropertiesText()
        {
            sectionNameText.text = " ";
            seniorityLevelText.text = " ";
            employeesAmountText.text = " ";
            salaryIncrementPercentageText.text = " ";
            baseSalaryText.text = " ";
            actualSalaryText.text = " ";
        }

        public void SetAllPropertiesText(CompanyViewUpdateData companyViewUpdateData)
        {
            sectionNameText.text = companyViewUpdateData.SectionName;
            seniorityLevelText.text = companyViewUpdateData.SeniorityLevel;
            employeesAmountText.text = companyViewUpdateData.EmployeesAmount;
            salaryIncrementPercentageText.text = companyViewUpdateData.SectionName;
            baseSalaryText.text = companyViewUpdateData.SectionName;
            actualSalaryText.text = companyViewUpdateData.SectionName;
        }

        public void SetActualSalaryText(string text)
        {
            actualSalaryText.text = text;
        }
    }
}

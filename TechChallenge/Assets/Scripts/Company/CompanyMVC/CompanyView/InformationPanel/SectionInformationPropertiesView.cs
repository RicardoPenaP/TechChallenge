using TMPro;
using UnityEngine;


namespace Company.CompanyMVC.CompanyView.InformationPanel
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

        public void SetAllPropertiesText(string sectionNameTex, string seniorityLevelText, string employeesAmountText, string salaryIncrementPercentageText, string baseSalaryText, string actualSalaryText)
        {
            this.sectionNameText.text = sectionNameTex;
            this.seniorityLevelText.text = seniorityLevelText;
            this.employeesAmountText.text = employeesAmountText;
            this.salaryIncrementPercentageText.text = salaryIncrementPercentageText;
            this.baseSalaryText.text = baseSalaryText;
            this.actualSalaryText.text = actualSalaryText;
        }

    }
}

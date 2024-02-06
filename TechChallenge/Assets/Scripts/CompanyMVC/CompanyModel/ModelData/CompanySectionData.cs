using Company.Enums;
using UnityEngine;

namespace CompanyMVC.CompanyModel.ModelData
{
    [CreateAssetMenu(fileName ="NewCompanySectionData", menuName = "Company Section Data")]
    public class CompanySectionData : ScriptableObject
    {
        [Header("Company Section Data")]
        [SerializeField] private string companySectionName;
        [SerializeField] private SeniorityLevels[] seniorityLevels;
        [SerializeField] private int[] employeesAmount;
        [SerializeField] private float[] salaryIncrementPercentage;
        [SerializeField] private float[] baseSalary;

        public string CompanySectionName => companySectionName;
        public SeniorityLevels[] SeniorityLevels => seniorityLevels;
        public int[] EmployeesAmount => employeesAmount;
        public float[] SalaryIncrementPercentage => SalaryIncrementPercentage;
        public float[] BaseSalary => BaseSalary;


        private void OnValidate()
        {
            if (employeesAmount.Length != seniorityLevels.Length)
            {
                employeesAmount = new int[seniorityLevels.Length];
            }

            if (salaryIncrementPercentage.Length != seniorityLevels.Length)
            {
                salaryIncrementPercentage = new float[seniorityLevels.Length];
            }

            if (baseSalary.Length != seniorityLevels.Length)
            {
                baseSalary = new float[seniorityLevels.Length];
            }
        }

    }
}

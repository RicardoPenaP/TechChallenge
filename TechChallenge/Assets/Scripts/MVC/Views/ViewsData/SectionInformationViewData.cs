using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVC.Views.ViewsData
{
    public class SectionInformationViewData 
    {
        private string sectionName;
        private string[] seniorityLevelsArray;
        private string[] employeesAmountsArrary;
        private string[] salaryIncrementPercentagesArray;
        private string[] baseSalariesArray;
        private string[] actualSalariesArray;

        public string SectionName => sectionName;
        public string[] SeniorityLevelsArray => seniorityLevelsArray;
        public string[] EmployeesAmountArray => employeesAmountsArrary;
        public string[] SalaryIncrementPercentagesArray => salaryIncrementPercentagesArray;
        public string[] BaseSalariesArray => baseSalariesArray;
        public string[] ActualSalariesArrar =>actualSalariesArray;

        public SectionInformationViewData(string sectionName, string[] seniorityLevelsArray, string[] employeesAmountsArrary,
                                      string[] salaryIncrementPercentagesArray, string[] baseSalariesArray, string[] actualSalariesArray)
        {
            this.sectionName = sectionName;
            this.seniorityLevelsArray = seniorityLevelsArray;
            this.employeesAmountsArrary = employeesAmountsArrary;
            this.salaryIncrementPercentagesArray = salaryIncrementPercentagesArray;
            this.baseSalariesArray = baseSalariesArray;
            this.actualSalariesArray = actualSalariesArray;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Company.CompanyMVC.CompanyView
{
    public class CompanyViewUpdateData 
    {
        private string sectionName;
        private string seniorityLevel;
        private string amountOfEmployees;
        private string salaryIncrementPercentage;
        private string baseSalary;
        private string actualSalary;

        public string SectionName => sectionName;
        public string SeniorityLevel => seniorityLevel;
        public string AmountOfEmployees => amountOfEmployees;
        public string SalaryincrementPercentage => salaryIncrementPercentage;
        public string BaseSalary => baseSalary;
        public string ActualSalary => actualSalary;        

        public CompanyViewUpdateData(string sectionName, string seniorityLevel, string amountOfEmployees, string salaryIncrementPercentage, string baseSalary, string actualSalary)
        {
            this.sectionName = sectionName;
            this.seniorityLevel = seniorityLevel;
            this.amountOfEmployees = amountOfEmployees;
            this.salaryIncrementPercentage = salaryIncrementPercentage;
            this.baseSalary = baseSalary;
            this.actualSalary = actualSalary;
        }
    }
}

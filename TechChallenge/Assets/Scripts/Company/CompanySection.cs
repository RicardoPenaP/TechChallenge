using Company.Employees;
using Company.Enums;
using System.Collections.Generic;
using UnityEngine;

namespace Company
{
    public class CompanySection
    {
        private Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployeesDictionary;

        public CompanySection()
        {
            sectionEmployeesDictionary = new Dictionary<SeniorityLevels, EmployeesInformation>();
        }

        public void SetSectionEmployeesDictionary(Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployeesDictionary)
        {
            this.sectionEmployeesDictionary = sectionEmployeesDictionary;
        }

        public Dictionary<SeniorityLevels, EmployeesInformation> GetSectionEmployeesDictionary()
        {
            return sectionEmployeesDictionary;
        }

        public float GetSalariesBySeniorityLevel(SeniorityLevels seniorityLevel)
        {
            if (sectionEmployeesDictionary.ContainsKey(seniorityLevel))
            {
                return sectionEmployeesDictionary[seniorityLevel].SalaryAmount;
            }
            else
            {
                Debug.Log("This company section doesn't have any salary amount for that seniority level");
                return 0;
            }
        }
    }
}

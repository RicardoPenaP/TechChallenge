using Company.Employees;
using Company.Enums;
using System.Collections.Generic;

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
    }
}

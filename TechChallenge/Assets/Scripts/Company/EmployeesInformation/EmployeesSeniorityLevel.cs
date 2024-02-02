using Company.Enums;
using Company.Interfaces;

namespace Company.EmployeesInformation
{
    public class EmployeesSeniorityLevel : IEmployeeProperty<SeniorityLevels>
    {
        private SeniorityLevels seniorityLevel;

        public EmployeesSeniorityLevel(SeniorityLevels seniorityLevel)
        {
            this.seniorityLevel = seniorityLevel;
        }

        public SeniorityLevels GetPropertyValue()
        {
            return seniorityLevel;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.Enums;

namespace Company.Employees
{
    public class EmployeesInformation 
    {
        private SeniorityLevels seniorityLevel;
        private int employeesAmount;

        public SeniorityLevels SeniorityLevels { get { return seniorityLevel; } }
        public int EmployeesAmount { get { return employeesAmount; } }

        public EmployeesInformation()
        {
            seniorityLevel = SeniorityLevels.None;
            employeesAmount = 0;
        }

        public void SetSeniorityLevel(SeniorityLevels seniorityLevel)
        {
            this.seniorityLevel = seniorityLevel;
        }

        public void SetEmployeesAmount(int employeesAmount)
        {
            this.employeesAmount = employeesAmount;
        }
    }
}

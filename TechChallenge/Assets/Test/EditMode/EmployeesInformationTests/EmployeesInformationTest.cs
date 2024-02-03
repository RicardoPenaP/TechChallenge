using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Company.Employees.EmployeesProperties;
using Company.Employees;

namespace EditMode.EmployeesInformationTests
{
    public class EmployeesInformationTest
    {        
        [Test]
        public void EmployeesInformationEmployeesAmountPropertyTest()
        {
            int testedAmount = 10;
            EmployeesInformation employeesInformation = new EmployeesInformation();
            EmployeesAmount employeesAmount = new EmployeesAmount(testedAmount);

            employeesInformation.AddEmployeesProperty(employeesAmount);

            int targetAmount = 10;
            int testResult = employeesInformation.GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();

            Assert.AreEqual(targetAmount,testResult);
        }

        
    }
}

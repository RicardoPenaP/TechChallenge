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
        public void EmployeesAmountPropertyTest()
        {
            int testedAmount = 10;
            EmployeesInformation employeesInformation = new EmployeesInformation();
            EmployeesAmount employeesAmount = new EmployeesAmount(testedAmount);

            employeesInformation.AddEmployeesProperty(employeesAmount);

            int targetAmount = 10;
            int testResult = employeesInformation.GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();

            Assert.AreEqual(targetAmount,testResult);
        }

        [Test]
        public void SalaryIncrementPercentagePropertyTest()
        {
            float testedAmount = 10f;
            EmployeesInformation employeesInformation = new EmployeesInformation();
            SalaryIncrementPercentage salaryIncrementPercentage = new SalaryIncrementPercentage(testedAmount);

            employeesInformation.AddEmployeesProperty(salaryIncrementPercentage);

            float targetAmount = 10f;
            float testResult = employeesInformation.GetEmployeesProperty<SalaryIncrementPercentage>().ReadPropertyValue<float>();

            Assert.AreEqual(targetAmount, testResult);
        }

        [Test]
        public void BaseSalaryPercentagePropertyTest()
        {
            float testedAmount = 1000f;
            EmployeesInformation employeesInformation = new EmployeesInformation();
            BaseSalary baseSalary = new BaseSalary(testedAmount);

            employeesInformation.AddEmployeesProperty(baseSalary);

            float targetAmount = 1000f;
            float testResult = employeesInformation.GetEmployeesProperty<BaseSalary>().ReadPropertyValue<float>();

            Assert.AreEqual(targetAmount, testResult);
        }

    }
}

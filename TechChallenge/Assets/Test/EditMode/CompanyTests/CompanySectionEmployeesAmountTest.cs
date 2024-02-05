using Company;
using Company.Employees;
using Company.Enums;
using NUnit.Framework;
using System.Collections.Generic;
using Company.Employees.EmployeesProperties;

namespace EditMode.CompanyTests
{
    public class CompanySectionEmployeesAmountTest
    {
        [Test]
        public void HRSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 5, 2, 13 };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            int[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySectionEmployeesAmountArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void EngineeringSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 50, 68, 32 };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            int[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySectionEmployeesAmountArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void ArtistSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 5, 20 };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            int[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySectionEmployeesAmountArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void DesignSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 10, 15 };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            int[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySectionEmployeesAmountArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void PMsSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 10, 20 };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            int[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySectionEmployeesAmountArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void CeoSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 1 };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.None};

            int[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySectionEmployeesAmountArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }
    }
}


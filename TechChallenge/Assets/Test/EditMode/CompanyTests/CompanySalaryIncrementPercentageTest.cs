using Company;
using Company.Employees;
using Company.Enums;
using NUnit.Framework;
using System.Collections.Generic;

namespace EditMode.CompanyTests
{
    public class CompanySalaryIncrementPercentageTest
    {
        [Test]
        public void HRSectionSalaryIncrementPercentageTest()
        {
            float[] employeesAmounts = new float[] { 5f, 2f, 0.5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void EngineeringSectionSalaryIncrementPercentageTest()
        {
            float[] employeesAmounts = new float[] { 10f, 7f, 5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void ArtistSectionSalaryIncrementPercentageTest()
        {
            float[] employeesAmounts = new float[] { 5f, 2.5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void DesignSectionSalaryIncrementPercentageTest()
        {
            float[] employeesAmounts = new float[] { 7f, 4f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void PMsSectionSalaryIncrementPercentageTest()
        {
            float[] employeesAmounts = new float[] { 10f, 5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void CeoSectionSalaryIncrementPercentageTest()
        {
            float[] employeesAmounts = new float[] { 100f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.None };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

    }
}


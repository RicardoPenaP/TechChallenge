using Company.Enums;
using NUnit.Framework;

namespace EditMode.CompanyTests
{
    public class CompanySalaryIncrementPercentageTest
    {
        [Test]
        public void HRSectionSalaryIncrementPercentageTest()
        {
            float[] salaryIncrementPercentages = new float[] { 5f, 2f, 0.5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(salaryIncrementPercentages, seniorityLevels);

            Assert.AreEqual(targetAmounts, salaryIncrementPercentages);
        }

        [Test]
        public void EngineeringSectionSalaryIncrementPercentageTest()
        {
            float[] salaryIncrementPercentages = new float[] { 10f, 7f, 5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(salaryIncrementPercentages, seniorityLevels);

            Assert.AreEqual(targetAmounts, salaryIncrementPercentages);
        }

        [Test]
        public void ArtistSectionSalaryIncrementPercentageTest()
        {
            float[] salaryIncrementPercentages = new float[] { 5f, 2.5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(salaryIncrementPercentages, seniorityLevels);

            Assert.AreEqual(targetAmounts, salaryIncrementPercentages);
        }

        [Test]
        public void DesignSectionSalaryIncrementPercentageTest()
        {
            float[] salaryIncrementPercentages = new float[] { 7f, 4f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(salaryIncrementPercentages, seniorityLevels);

            Assert.AreEqual(targetAmounts, salaryIncrementPercentages);
        }

        [Test]
        public void PMsSectionSalaryIncrementPercentageTest()
        {
            float[] salaryIncrementPercentages = new float[] { 10f, 5f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(salaryIncrementPercentages, seniorityLevels);

            Assert.AreEqual(targetAmounts, salaryIncrementPercentages);
        }

        [Test]
        public void CeoSectionSalaryIncrementPercentageTest()
        {
            float[] salaryIncrementPercentages = new float[] { 100f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.None };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanySalaryIncrementArrayForTesting(salaryIncrementPercentages, seniorityLevels);

            Assert.AreEqual(targetAmounts, salaryIncrementPercentages);
        }

    }
}


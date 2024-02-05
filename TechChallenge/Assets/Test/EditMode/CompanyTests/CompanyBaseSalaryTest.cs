using Company.Enums;
using NUnit.Framework;

namespace EditMode.CompanyTests
{
    public class CompanyBaseSalaryTest
    {
        [Test]
        public void HRSectionBaseSalaryTest()
        {
            float[] baseSalaries = new float[] { 1500f, 1000f, 500f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanyBaseSalaryArrayForTesting(baseSalaries, seniorityLevels);

            Assert.AreEqual(targetAmounts, baseSalaries);
        }

        [Test]
        public void EngineeringSectionBaseSalaryTest()
        {
            float[] baseSalaries = new float[] { 5000f, 3000f, 1500f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanyBaseSalaryArrayForTesting(baseSalaries, seniorityLevels);

            Assert.AreEqual(targetAmounts, baseSalaries);
        }

        [Test]
        public void ArtistSectionBaseSalaryTest()
        {
            float[] baseSalaries = new float[] { 2000f, 1200f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanyBaseSalaryArrayForTesting(baseSalaries, seniorityLevels);

            Assert.AreEqual(targetAmounts, baseSalaries);
        }

        [Test]
        public void DesignSectionBaseSalaryTest()
        {
            float[] baseSalaries = new float[] { 2000f, 800f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.Junior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanyBaseSalaryArrayForTesting(baseSalaries, seniorityLevels);

            Assert.AreEqual(targetAmounts, baseSalaries);
        }

        [Test]
        public void PMsSectionBaseSalaryTest()
        {
            float[] baseSalaries = new float[] { 4000f, 2400f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanyBaseSalaryArrayForTesting(baseSalaries, seniorityLevels);

            Assert.AreEqual(targetAmounts, baseSalaries);
        }

        [Test]
        public void CeoSectionBaseSalarytTest()
        {
            float[] baseSalaries = new float[] { 20000f };

            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.None };

            float[] targetAmounts = CompanyUnitTestingDataGenerator.GenerateCompanyBaseSalaryArrayForTesting(baseSalaries, seniorityLevels);

            Assert.AreEqual(targetAmounts, baseSalaries);
        }

    }
}


using Company;
using Company.Employees;
using Company.Enums;
using NUnit.Framework;
using System.Collections.Generic;

namespace EditMode.CompanyTests
{
    public class CompanySalariesIncreaseTest
    {        
        [Test]
        public void HRSectionSalaryIncreaseTest()
        {
            float[] baseSalaries = new float[] { 1500f, 1000f, 500f };
            float[] targetSalaries = new float[] { 1575f, 1020f, 502.5f };
            float[] incrementPercentage = new float[] { 5f, 2f, 0.5f };
            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] newSalaries = CompanyUnitTestingDataGenerator.GenerateCompanyIncrementedSalaryArrayForTesting(baseSalaries,incrementPercentage,seniorityLevels);

            Assert.AreEqual(targetSalaries, newSalaries);
        }

        [Test]
        public void EngineeringSectionSalaryIncreaseTest()
        {
            float[] baseSalaries = new float[] { 5000f, 3000f, 1500f };
            float[] targetSalaries = new float[] { 5500f, 3210f, 1575f };
            float[] incrementPercentage = new float[] { 10f, 7f, 5f };
            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] newSalaries = CompanyUnitTestingDataGenerator.GenerateCompanyIncrementedSalaryArrayForTesting(baseSalaries, incrementPercentage, seniorityLevels);

            Assert.AreEqual(targetSalaries, newSalaries);

            Assert.AreEqual(targetSalaries, newSalaries);
        }

        [Test]
        public void ArtistSectionSalaryIncreaseTest()
        {
            float[] baseSalaries = new float[] { 2000f, 1200f };
            float[] targetSalaries = new float[] { 2100f, 1230 };
            float[] incrementPercentage = new float[] { 5f, 2.5f };
            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] newSalaries = CompanyUnitTestingDataGenerator.GenerateCompanyIncrementedSalaryArrayForTesting(baseSalaries, incrementPercentage, seniorityLevels);

            Assert.AreEqual(targetSalaries, newSalaries);

            Assert.AreEqual(targetSalaries, newSalaries);
        }

        [Test]
        public void DesignSectionSalaryIncreaseTest()
        {
            float[] baseSalaries = new float[] { 2000f, 800f };
            float[] targetSalaries = new float[] { 2140f, 832 };
            float[] incrementPercentage = new float[] { 7f, 4f };
            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] newSalaries = CompanyUnitTestingDataGenerator.GenerateCompanyIncrementedSalaryArrayForTesting(baseSalaries, incrementPercentage, seniorityLevels);

            Assert.AreEqual(targetSalaries, newSalaries);

            Assert.AreEqual(targetSalaries, newSalaries);
        }

        [Test]
        public void PMsSectionSalaryIncreaseTest()
        {
            float[] baseSalaries = new float[] { 4000f, 2400f };
            float[] targetSalaries = new float[] { 4400f, 2520 };
            float[] incrementPercentage = new float[] { 10f, 5f };
            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] newSalaries = CompanyUnitTestingDataGenerator.GenerateCompanyIncrementedSalaryArrayForTesting(baseSalaries, incrementPercentage, seniorityLevels);

            Assert.AreEqual(targetSalaries, newSalaries);

            Assert.AreEqual(targetSalaries, newSalaries);
        }

        [Test]
        public void CeoSectionSalaryIncreaseTest()
        {
            float[] baseSalaries = new float[] { 20000f };
            float[] targetSalaries = new float[] { 40000f };
            float[] incrementPercentage = new float[] { 100f };
            SeniorityLevels[] seniorityLevels = new SeniorityLevels[] { SeniorityLevels.Senior, SeniorityLevels.SemiSenior, SeniorityLevels.Junior };

            float[] newSalaries = CompanyUnitTestingDataGenerator.GenerateCompanyIncrementedSalaryArrayForTesting(baseSalaries, incrementPercentage, seniorityLevels);

            Assert.AreEqual(targetSalaries, newSalaries);

            Assert.AreEqual(targetSalaries, newSalaries);
        }




    }
}


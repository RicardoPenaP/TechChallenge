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

            int[] targetAmounts = GenerateCompanySectionEmployeesAmountArrayForTesting(employeesAmounts, seniorityLevels);

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void EngineeringSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 5, 2, 13 };
            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            EmployeesInformation seniorsInformation = new EmployeesInformation();
            seniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[0]));

            EmployeesInformation semiSeniorsInformation = new EmployeesInformation();
            semiSeniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[1]));

            EmployeesInformation juniorInformation = new EmployeesInformation();
            juniorInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[2]));

            sectionEmployees.Add(SeniorityLevels.Senior, seniorsInformation);
            sectionEmployees.Add(SeniorityLevels.SemiSenior, semiSeniorsInformation);
            sectionEmployees.Add(SeniorityLevels.Junior, juniorInformation);

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            int[] targetAmounts = new int[employeesAmounts.Length];

            targetAmounts[0] = targetEmployees[SeniorityLevels.Senior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[1] = targetEmployees[SeniorityLevels.SemiSenior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[2] = targetEmployees[SeniorityLevels.Junior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void ArtistSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 5, 2, 13 };
            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            EmployeesInformation seniorsInformation = new EmployeesInformation();
            seniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[0]));

            EmployeesInformation semiSeniorsInformation = new EmployeesInformation();
            semiSeniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[1]));

            EmployeesInformation juniorInformation = new EmployeesInformation();
            juniorInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[2]));

            sectionEmployees.Add(SeniorityLevels.Senior, seniorsInformation);
            sectionEmployees.Add(SeniorityLevels.SemiSenior, semiSeniorsInformation);
            sectionEmployees.Add(SeniorityLevels.Junior, juniorInformation);

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            int[] targetAmounts = new int[employeesAmounts.Length];

            targetAmounts[0] = targetEmployees[SeniorityLevels.Senior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[1] = targetEmployees[SeniorityLevels.SemiSenior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[2] = targetEmployees[SeniorityLevels.Junior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void DesignSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 5, 2, 13 };
            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            EmployeesInformation seniorsInformation = new EmployeesInformation();
            seniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[0]));

            EmployeesInformation semiSeniorsInformation = new EmployeesInformation();
            semiSeniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[1]));

            EmployeesInformation juniorInformation = new EmployeesInformation();
            juniorInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[2]));

            sectionEmployees.Add(SeniorityLevels.Senior, seniorsInformation);
            sectionEmployees.Add(SeniorityLevels.SemiSenior, semiSeniorsInformation);
            sectionEmployees.Add(SeniorityLevels.Junior, juniorInformation);

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            int[] targetAmounts = new int[employeesAmounts.Length];

            targetAmounts[0] = targetEmployees[SeniorityLevels.Senior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[1] = targetEmployees[SeniorityLevels.SemiSenior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[2] = targetEmployees[SeniorityLevels.Junior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void PMsSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 5, 2, 13 };
            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            EmployeesInformation seniorsInformation = new EmployeesInformation();
            seniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[0]));

            EmployeesInformation semiSeniorsInformation = new EmployeesInformation();
            semiSeniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[1]));

            EmployeesInformation juniorInformation = new EmployeesInformation();
            juniorInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[2]));

            sectionEmployees.Add(SeniorityLevels.Senior, seniorsInformation);
            sectionEmployees.Add(SeniorityLevels.SemiSenior, semiSeniorsInformation);
            sectionEmployees.Add(SeniorityLevels.Junior, juniorInformation);

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            int[] targetAmounts = new int[employeesAmounts.Length];

            targetAmounts[0] = targetEmployees[SeniorityLevels.Senior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[1] = targetEmployees[SeniorityLevels.SemiSenior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[2] = targetEmployees[SeniorityLevels.Junior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        [Test]
        public void CeoSectionEmployeesTest()
        {
            int[] employeesAmounts = new int[] { 5, 2, 13 };
            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            EmployeesInformation seniorsInformation = new EmployeesInformation();
            seniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[0]));

            EmployeesInformation semiSeniorsInformation = new EmployeesInformation();
            semiSeniorsInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[1]));

            EmployeesInformation juniorInformation = new EmployeesInformation();
            juniorInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[2]));

            sectionEmployees.Add(SeniorityLevels.Senior, seniorsInformation);
            sectionEmployees.Add(SeniorityLevels.SemiSenior, semiSeniorsInformation);
            sectionEmployees.Add(SeniorityLevels.Junior, juniorInformation);

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            int[] targetAmounts = new int[employeesAmounts.Length];

            targetAmounts[0] = targetEmployees[SeniorityLevels.Senior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[1] = targetEmployees[SeniorityLevels.SemiSenior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            targetAmounts[2] = targetEmployees[SeniorityLevels.Junior].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();

            Assert.AreEqual(targetAmounts, employeesAmounts);
        }

        private int[] GenerateCompanySectionEmployeesAmountArrayForTesting(int[] startingValues, SeniorityLevels[] seniorityLevels)
        {
            int[] employeesAmounts = startingValues;
            SeniorityLevels[] employeesSeniorityLevels = seniorityLevels;

            int arraysLenght = employeesAmounts.Length;

            Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

            for (int i = 0; i < arraysLenght; i++)
            {
                EmployeesInformation employeesInformation = new EmployeesInformation();
                employeesInformation.AddEmployeesProperty(new EmployeesAmount(employeesAmounts[i]));
                sectionEmployees.Add(employeesSeniorityLevels[i], employeesInformation);
            }

            CompanySection companySection = new CompanySection();
            companySection.SetSectionEmployeesDictionary(sectionEmployees);

            Dictionary<SeniorityLevels, EmployeesInformation> targetEmployees = companySection.GetSectionEmployeesDictionary();

            int[] targetAmounts = new int[employeesAmounts.Length];

            for (int i = 0; i < arraysLenght; i++)
            {
                targetAmounts[i] = targetEmployees[employeesSeniorityLevels[i]].GetEmployeesProperty<EmployeesAmount>().ReadPropertyValue<int>();
            }

            return targetAmounts;
        }

    }
}


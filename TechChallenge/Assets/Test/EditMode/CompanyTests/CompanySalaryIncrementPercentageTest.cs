using Company;
using Company.Employees;
using Company.Enums;
using NUnit.Framework;
using System.Collections.Generic;


public class CompanySalaryIncrementPercentageTest
{
    [Test]
    public void HRSectionSalaryIncrementPercentageTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 5, 0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 2, 0));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, 0.5f, 0));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void EngineeringSectionSalaryIncrementPercentageTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 10, 0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 7, 0));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, 5, 0));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void ArtistSectionSalaryIncrementPercentageTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 5, 0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 2.5f, 0));        

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void DesignSectionSalaryIncrementPercentageTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 7, 0));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, 4, 0));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void PMsSectionSalaryIncrementPercentageTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 10, 0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 5, 0));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void CeoSectionSalaryIncrementPercentageTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.None, new EmployeesInformation(0, 100, 0));       

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

}

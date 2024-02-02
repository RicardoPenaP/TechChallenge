using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Company;
using Company.Employees;
using Company.Enums;

public class CompanyBaseSalaryTest
{
    [Test]
    public void HRSectionSalaryBaseTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 0, 1500));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 0, 1000));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, 0, 500));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void EngineeringSectionSalaryBaseTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 0, 5000));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 0, 3000));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, 0, 1500));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void ArtistSectionSalaryBaseTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 0, 2000));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 0, 1200));        

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void DesignSectionSalaryBaseTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 0, 2000));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, 0, 800));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void PMsSectionSalaryBaseTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 0, 4000));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 0, 2400));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void CeoSectionSalaryBaseTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.None, new EmployeesInformation(0, 0, 20000));        

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

}

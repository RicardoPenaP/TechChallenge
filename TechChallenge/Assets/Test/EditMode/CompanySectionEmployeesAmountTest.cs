using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Company.Employees;
using Company.Enums;
using Company;

public class CompanySectionEmployeesAmountTest
{    
    [Test]
    public void HRSectionEmployeesTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();
      
        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(5,0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(2, 0));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(13, 0));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void EngineeringSectionEmployeesTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(50, 0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(68, 0));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(32, 0));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void ArtistSectionEmployeesTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(5, 0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(20, 0));
        
        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void DesignSectionEmployeesTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(10, 0));        
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(15, 0));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void PMsSectionEmployeesTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(10, 0));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(20, 0));       

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

    [Test]
    public void CeoSectionEmployeesTest()
    {
        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.None, new EmployeesInformation(1, 0));        

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

}

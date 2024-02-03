using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Company;
using Company.Employees;
using Company.Enums;
using Tools.Calculators;

public class CompanySalariesIncreaseTest
{
    private float[] GetNewSalaries(CompanySection companySection)
    {
        List<float> newSalariesList = new List<float>();
        foreach (KeyValuePair<SeniorityLevels, EmployeesInformation> keyValuePair in companySection.GetSectionEmployeesDictionary())
        {
            newSalariesList.Add(keyValuePair.Value.SalaryAmount);
        }
        float[] newSalariesArray = new float[newSalariesList.Count];

        for (int i = 0; i < newSalariesArray.Length; i++)
        {
            newSalariesArray[i] = newSalariesList[i];
        }
        return newSalariesArray;
    }

    [Test]
    public void HRSectionSalaryIncreaseTest()
    {
        float[] baseSalaries = new float[] { 1500f, 1000f, 500f };
        float[] targetSalaries = new float[] { 1575f, 1020f, 502.5f };
        float[] incrementPercentage = new float[] { 5f, 2f, 0.5f };

        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, incrementPercentage[0], baseSalaries[0]));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, incrementPercentage[1], baseSalaries[1]));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, incrementPercentage[2], baseSalaries[2]));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);
        companySection.IncreaseSectionEmployeesSalaries();

        float[] newSalaries = GetNewSalaries(companySection);

        Assert.AreEqual(targetSalaries, newSalaries);
    }

    [Test]
    public void EngineeringSectionSalaryIncreaseTest()
    {
        float[] baseSalaries = new float[] { 5000f, 3000f, 1500f };
        float[] targetSalaries = new float[] { 5500f, 3210f, 1575f };
        float[] incrementPercentage = new float[] { 10f, 7f, 5f };

        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, incrementPercentage[0], baseSalaries[0]));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, incrementPercentage[1], baseSalaries[1]));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, incrementPercentage[2], baseSalaries[2]));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);
        companySection.IncreaseSectionEmployeesSalaries();

        float[] newSalaries = GetNewSalaries(companySection);

        Assert.AreEqual(targetSalaries, newSalaries);
    }

    [Test]
    public void ArtistSectionSalaryIncreaseTest()
    {
        float[] baseSalaries = new float[] { 2000f, 1200f };
        float[] targetSalaries = new float[] { 2100f, 1230 };
        float[] incrementPercentage = new float[] { 5f, 2.5f };

        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, incrementPercentage[0], baseSalaries[0]));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, incrementPercentage[1], baseSalaries[1]));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);
        companySection.IncreaseSectionEmployeesSalaries();

        float[] newSalaries = GetNewSalaries(companySection);

        Assert.AreEqual(targetSalaries, newSalaries);
    }

    [Test]
    public void DesignSectionSalaryIncreaseTest()
    {
        float[] baseSalaries = new float[] { 2000f, 800f };
        float[] targetSalaries = new float[] { 2140f, 832 };
        float[] incrementPercentage = new float[] { 7f, 4f };

        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, incrementPercentage[0], baseSalaries[0]));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, incrementPercentage[1], baseSalaries[1]));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);
        companySection.IncreaseSectionEmployeesSalaries();

        float[] newSalaries = GetNewSalaries(companySection);

        Assert.AreEqual(targetSalaries, newSalaries);
    }

    [Test]
    public void PMsSectionSalaryIncreaseTest()
    {
        float[] baseSalaries = new float[] { 4000f, 2400f };
        float[] targetSalaries = new float[] { 4400f, 2520 };
        float[] incrementPercentage = new float[] { 10f, 5f };

        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, incrementPercentage[0], baseSalaries[0]));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, incrementPercentage[1], baseSalaries[1]));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);
        companySection.IncreaseSectionEmployeesSalaries();

        float[] newSalaries = GetNewSalaries(companySection);

        Assert.AreEqual(targetSalaries, newSalaries);
    }

    [Test]
    public void CeoSectionSalaryIncreaseTest()
    {
        float[] baseSalaries = new float[] { 20000f};
        float[] targetSalaries = new float[] { 40000f};
        float[] incrementPercentage = new float[] { 100f };

        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.None, new EmployeesInformation(0, incrementPercentage[0], baseSalaries[0]));        

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);
        companySection.IncreaseSectionEmployeesSalaries();

        float[] newSalaries = GetNewSalaries(companySection);

        Assert.AreEqual(targetSalaries, newSalaries);
    }




}

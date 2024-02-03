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
    [Test]
    public void HRSectionSalaryIncreaseTest()
    {
        float[] baseSalaries = new float[] { 1500f, 1000f, 500f };
        float[] targetSalaries = new float[] { 1575f, 1020f, 502.5f};

        Dictionary<SeniorityLevels, EmployeesInformation> sectionEmployees = new Dictionary<SeniorityLevels, EmployeesInformation>();

        sectionEmployees.Add(SeniorityLevels.Senior, new EmployeesInformation(0, 5f, baseSalaries[0]));
        sectionEmployees.Add(SeniorityLevels.SemiSenior, new EmployeesInformation(0, 2f, baseSalaries[1]));
        sectionEmployees.Add(SeniorityLevels.Junior, new EmployeesInformation(0, 0.5f, baseSalaries[2]));

        CompanySection companySection = new CompanySection();
        companySection.SetSectionEmployeesDictionary(sectionEmployees);
        companySection.IncreaseSectionEmployeesSalaries();

        float[] newSalaries = GetNewSalaries(companySection);

        Assert.AreEqual(sectionEmployees, companySection.GetSectionEmployeesDictionary());
    }

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


}

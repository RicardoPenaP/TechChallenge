using Company;
using MVC.Views.ViewsData;
using System.Collections.Generic;
using UnityEngine;

namespace MVC.DataFormatters
{
    public static class ControllerDataFormatter 
    {
        public static CompanyInformationViewData FormatCompanyInformationToCompanyInformationViewData(CompanyInformation companyInformation)
        {
            List<CompanySection> companySections = companyInformation.GetCompanySectionsList();
            int companySectionsAmount = companySections.Count;

            SectionInformationViewData[] sectionInformationViewDataArray = new SectionInformationViewData[companySectionsAmount];
            for (int i = 0; i < sectionInformationViewDataArray.Length; i++)
            {
                string sectionName = companySections[i].GetSectionName();
                
            }


            return null;
        }
    }
}

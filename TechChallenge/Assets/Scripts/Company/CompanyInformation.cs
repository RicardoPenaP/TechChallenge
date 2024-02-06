using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Company
{
    public class CompanyInformation
    {
        private string companyName;
        private List<CompanySection> companySectionsList;
        
        public CompanyInformation(string companyName,List<CompanySection> companySectionsList)
        {
            this.companyName = companyName;
            this.companySectionsList = companySectionsList;
        }
    }
    
}

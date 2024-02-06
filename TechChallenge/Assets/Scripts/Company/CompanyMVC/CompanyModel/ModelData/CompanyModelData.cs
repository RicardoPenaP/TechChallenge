using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Company.CompanyMVC.CompanyModel.ModelData
{
    [CreateAssetMenu(fileName = "NewCompanyModelData", menuName = "Company Model Data")]
    public class CompanyModelData : ScriptableObject
    {
        [Header("Company Model Data")]
        [SerializeField] private CompanySectionData[] companySections;

        public CompanySectionData[] CompanySections => companySections;
    }
}

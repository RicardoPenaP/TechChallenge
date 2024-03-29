using UnityEngine;

namespace MVC.Models.ModelsData
{
    [CreateAssetMenu(fileName = "NewCompanyModelData", menuName = "Company Model Data")]
    public class CompanyModelData : ScriptableObject
    {
        [Header("Company Model Data")]
        [SerializeField] private string companyName;
        [SerializeField] private CompanySectionData[] companySections;

        public string CompanyName => companyName;
        public CompanySectionData[] CompanySections => companySections;
    }
}

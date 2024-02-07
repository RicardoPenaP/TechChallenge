using MVC.Views;
using MVC.Views.InformationPanel;
using UnityEngine;

namespace Company.CompanyMVC.Factories
{
    public class CompanyViewFactory : MonoBehaviour
    {
        [Header("Company View Factory")]
        [Header("Prefabs references")]
        [SerializeField] private SectionInformationPropertiesView sectionInformationPropertiesViewPrefab;

        public SectionInformationPropertiesView CreateSectionInformationPropertiesView(Transform parent, CompanyViewUpdateData sectionData)
        {
            SectionInformationPropertiesView newSectionInformationPropertiesView = Instantiate(sectionInformationPropertiesViewPrefab, parent);
            newSectionInformationPropertiesView.SetAllPropertiesText(sectionData);
            return newSectionInformationPropertiesView;
        }
    }
}

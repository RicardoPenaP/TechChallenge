using Company.CompanyMVC.CompanyView;
using Company.CompanyMVC.CompanyView.InformationPanel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Company.CompanyMVC.Tools
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

using MVC.Views;
using MVC.Views.InformationPanel;
using UnityEngine;
using TMPro;

namespace MVC.Factories
{
    public class CompanyViewFactory : MonoBehaviour
    {
        [Header("Company View Factory")]
        [Header("Prefabs references")]
        [SerializeField] private SectionInformationPropertiesView sectionInformationPropertiesViewPrefab;
        [SerializeField] private TextMeshProUGUI propertyInformationTextPrefab;
        

        public SectionInformationPropertiesView CreateSectionInformationPropertiesView(Transform parent, CompanyViewUpdateData sectionData)
        {
            SectionInformationPropertiesView newSectionInformationPropertiesView = Instantiate(sectionInformationPropertiesViewPrefab, parent);
            newSectionInformationPropertiesView.SetAllPropertiesText(sectionData);
            return newSectionInformationPropertiesView;
        }

        public TextMeshProUGUI CreatePropertyInformationText(Transform parent, string text)
        {
            TextMeshProUGUI newPropertyInformationText = Instantiate(propertyInformationTextPrefab, parent);
            newPropertyInformationText.text = text;
            return newPropertyInformationText;
        }
    }
}

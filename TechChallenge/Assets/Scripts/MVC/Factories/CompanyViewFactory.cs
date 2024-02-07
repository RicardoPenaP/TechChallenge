using MVC.Views.InformationPanel;
using MVC.Views.ViewsData;
using TMPro;
using UnityEngine;

namespace MVC.Factories
{
    public class CompanyViewFactory : MonoBehaviour
    {
        [Header("Company View Factory")]
        [Header("Prefabs references")]
        [SerializeField] private SectionInformationPanel sectionInformationPanelPrefab;
        [SerializeField] private TextMeshProUGUI propertyInformationTextPrefab;
        

        public SectionInformationPanel CreateSectionInformationPanel(Transform parent, SectionInformationViewData sectionInformationViewData)
        {
            SectionInformationPanel newSectionInformationPanel = Instantiate(sectionInformationPanelPrefab, parent);
            newSectionInformationPanel.InitializeSectionInformationPanel(sectionInformationViewData);
            return newSectionInformationPanel;
        }

        public TextMeshProUGUI CreatePropertyInformationText(Transform parent, string text)
        {
            TextMeshProUGUI newPropertyInformationText = Instantiate(propertyInformationTextPrefab, parent);
            newPropertyInformationText.text = text;
            return newPropertyInformationText;
        }
    }
}

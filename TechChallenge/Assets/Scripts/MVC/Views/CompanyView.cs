using MVC.Factories;
using MVC.Views.InformationPanel;
using MVC.Views.ViewsData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MVC.Views
{
    public class CompanyView : MonoBehaviour
    {
        [Header("Company View")]
        [Header("Runtime references")]
        [SerializeField] private CompanyViewFactory companyViewFactory;
        [SerializeField] private Transform sectionsInformationLayoutGroupTransform;
        [SerializeField] private Button incrementSalariesButton;

        public event Action OnIncrementSalariesButtonPressed;

        private List<SectionInformationPanel> activeSectionInformationPanelsList;

        private void Awake()
        {
            activeSectionInformationPanelsList = new List<SectionInformationPanel>();
            incrementSalariesButton.onClick.AddListener(() => OnIncrementSalariesButtonPressed?.Invoke());
        }

        private void OnDestroy()
        {
            incrementSalariesButton.onClick.RemoveListener(() => OnIncrementSalariesButtonPressed?.Invoke());
        }

        public void InitializeCompanySectionInformationPanels(CompanyInformationViewData companyInformationViewData)
        {
            foreach (SectionInformationViewData sectionInformationViewData in companyInformationViewData.CompanySectionsInformationViewDatas)
            {
                SectionInformationPanel newSectionInformationPanel = companyViewFactory.CreateSectionInformationPanel(sectionsInformationLayoutGroupTransform, sectionInformationViewData);
                activeSectionInformationPanelsList.Add(newSectionInformationPanel);
            }
        }

        public void UpdatedActualSalaries()
        {
            foreach (SectionInformationPanel sectionInformationPanel in activeSectionInformationPanelsList)
            {
                // Updated actual salaries logic  sectionInformationPanel.UpdateActualSalaryLayout()
            }
        }

    }
}

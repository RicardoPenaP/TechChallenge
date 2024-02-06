using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.CompanyMVC.CompanyView.InformationPanel;
using Company.CompanyMVC.Factories;
using UnityEngine.UI;
using System;

namespace Company.CompanyMVC.CompanyView
{
    public class CompanyView : MonoBehaviour
    {
        [Header("Company View")]
        [Header("Runtime references")]
        [SerializeField] private CompanyViewFactory companyViewFactory;
        [SerializeField] private Transform sectionsInformationLayoutGroupTransform;
        [SerializeField] private Button incrementSalariesButton;

        public event Action OnIncrementSalariesButtonPressed;

        private List<SectionInformationPropertiesView> activeSectionInformationPropertiesViewList;

        private void Awake()
        {
            activeSectionInformationPropertiesViewList = new List<SectionInformationPropertiesView>();
            incrementSalariesButton.onClick.AddListener(() => OnIncrementSalariesButtonPressed?.Invoke());
        }

        private void OnDestroy()
        {
            incrementSalariesButton.onClick.RemoveListener(() => OnIncrementSalariesButtonPressed?.Invoke());
        }

        public void AddCompanySectionInformation(CompanyViewUpdateData companyViewUpdateData)
        {
            activeSectionInformationPropertiesViewList.Add(companyViewFactory.CreateSectionInformationPropertiesView(sectionsInformationLayoutGroupTransform, companyViewUpdateData));
        }

    }
}

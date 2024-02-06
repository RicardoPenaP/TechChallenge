using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.CompanyMVC.CompanyView.InformationPanel;
using Company.CompanyMVC.Tools;
using UnityEngine.UI;

namespace Company.CompanyMVC.CompanyView
{
    public class CompanyView : MonoBehaviour
    {
        [Header("Company View")]
        [Header("Runtime references")]
        [SerializeField] private CompanyViewFactory companyViewFactory;
        [SerializeField] private Transform sectionsInformationLayoutGroupTransform;
        [SerializeField] private Button incrementSalariesButton;

        private List<SectionInformationPropertiesView> activeSectionInformationPropertiesViewList;

        private void Awake()
        {
            activeSectionInformationPropertiesViewList = new List<SectionInformationPropertiesView>();
        }

        public void AddCompanySectionInformation(CompanyViewUpdateData companyViewUpdateData)
        {
            activeSectionInformationPropertiesViewList.Add(companyViewFactory.CreateSectionInformationPropertiesView(sectionsInformationLayoutGroupTransform, companyViewUpdateData));
        }

    }
}

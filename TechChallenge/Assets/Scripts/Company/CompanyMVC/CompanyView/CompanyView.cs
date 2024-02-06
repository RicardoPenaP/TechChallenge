using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.CompanyMVC.CompanyView.InformationPanel;

namespace Company.CompanyMVC.CompanyView
{
    public class CompanyView : MonoBehaviour
    {
        [Header("Company View")]
        [Header("Runtime references")]
        [SerializeField] private Transform sectionsInformationLayoutGroupTransform;

        private List<SectionInformationPropertiesView> activeSectionInformationPropertiesViewList;

        private void Awake()
        {
            activeSectionInformationPropertiesViewList = new List<SectionInformationPropertiesView>();
        }

        public void AddCompanySectionInformation(CompanyViewUpdateData companyViewUpdateData)
        {

        }

    }
}

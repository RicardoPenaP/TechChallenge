using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.CompanyMVC.CompanyView.InformationPanel;

namespace Company.CompanyMVC.CompanyView
{
    public class CompanyView : MonoBehaviour
    {
        [Header("Company View")]
        [Header("Prefabs references")]
        [SerializeField] private SectionInformationPropertiesView sectionInformationPropertiesViewPrefab;

        [Header("Runtime references")]
        [SerializeField] private Transform sectionsInformationLayoutGroupTransform;


    }
}

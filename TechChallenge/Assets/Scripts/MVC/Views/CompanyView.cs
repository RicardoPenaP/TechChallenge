using MVC.Factories;
using MVC.Views.InformationPanel;
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

        public void InitializeCompanySectionInformationPanels()
        {
            //Implement the initialization logic for all the section in the view
        }

        public void UpdatedActualSalaries()
        {
            //Implement the logic for the actual salaries uptade
        }

    }
}

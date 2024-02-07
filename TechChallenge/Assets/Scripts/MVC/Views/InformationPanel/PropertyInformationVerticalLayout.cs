using MVC.Factories;
using System;
using UnityEngine;

namespace MVC.Views.InformationPanel
{
    public class PropertyInformationVerticalLayout : MonoBehaviour
    {
        private static CompanyViewFactory companyViewFactory;
        private static bool viewFactoryInitialized = false;

        private void Awake()
        {
            if (!viewFactoryInitialized)
            {
                companyViewFactory = FindObjectOfType<CompanyViewFactory>();
                viewFactoryInitialized = companyViewFactory != null;
            }
        }

        public void SetPropertiesInformationText(string[] texts)
        {
            if (!viewFactoryInitialized)
            {
                throw new InvalidOperationException("View Factory isn't initialized");                
            }

            DeletePreviusPropertiesTexts();

            foreach (string text in texts)
            {
                companyViewFactory.CreatePropertyInformationText(transform, text);
            }
        }

        private void DeletePreviusPropertiesTexts()
        {
            foreach (Transform transforms in transform)
            {
                Destroy(transform);
            }
        }

    }
}

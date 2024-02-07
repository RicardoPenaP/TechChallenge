using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC.Factories;

namespace MVC.Views.InformationPanel
{
    public class PropertyInformationVerticalLayout : MonoBehaviour
    {
        private static CompanyViewFactory companyViewFactory;
        private bool viewFactoryInitialized = false;

        private void Awake()
        {
            if (!viewFactoryInitialized)
            {
                companyViewFactory = FindObjectOfType<CompanyViewFactory>();
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC.Views;
using MVC.Models;

namespace MVC.Controllers
{
    public class CompanyController : MonoBehaviour
    {
        [Header("Company Controller")]
        [SerializeField] private CompanyView companyView;
        [SerializeField] private CompanyModel companyModel;

        private void Awake()
        {
            companyView.OnIncrementSalariesButtonPressed += CompanyView_OnIncrementSalariesButtonPressed;
        }

        private void OnDestroy()
        {
            companyView.OnIncrementSalariesButtonPressed -= CompanyView_OnIncrementSalariesButtonPressed;
        }

        private void CompanyView_OnIncrementSalariesButtonPressed()
        {
           //On increment button loggic pressed logic
        }
    }
}

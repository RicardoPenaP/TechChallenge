using TMPro;
using UnityEngine;

namespace MVC.Factories
{
    public class CompanyViewFactory : MonoBehaviour
    {
        [Header("Company View Factory")]
        [Header("Prefabs references")]
        
        [SerializeField] private TextMeshProUGUI propertyInformationTextPrefab;
        

        public TextMeshProUGUI CreatePropertyInformationText(Transform parent, string text)
        {
            TextMeshProUGUI newPropertyInformationText = Instantiate(propertyInformationTextPrefab, parent);
            newPropertyInformationText.text = text;
            return newPropertyInformationText;
        }
    }
}

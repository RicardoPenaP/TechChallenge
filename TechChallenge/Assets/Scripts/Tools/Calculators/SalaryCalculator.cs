using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools.Calculators
{
    public static class SalaryCalculator 
    {
        public static int CalculateSalaryIncrease(float increasePercentage, float currentSalary)
        {
            float unroundedSalary = currentSalary * (1 + (increasePercentage / 100));
            return Mathf.RoundToInt(unroundedSalary);
        }
    }
}

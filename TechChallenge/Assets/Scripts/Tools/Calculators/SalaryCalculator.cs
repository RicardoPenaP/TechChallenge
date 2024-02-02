using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tools.Calculators
{
    public static class SalaryCalculator 
    {
        public static int CalculateSalaryIncrease(float increasePercentage, int currentSalary)
        {
            float unroundedSalary = (float)currentSalary * (1 + (increasePercentage / 100));
            return Mathf.RoundToInt(unroundedSalary);
        }
    }
}

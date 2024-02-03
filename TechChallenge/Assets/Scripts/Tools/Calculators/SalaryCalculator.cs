using UnityEngine;

namespace Tools.Calculators
{
    public static class SalaryCalculator 
    {
        public static float CalculateSalaryIncrease(float increasePercentage, float currentSalary)
        {            
            return currentSalary * (1 + (increasePercentage / 100));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.Enums;
using System;

namespace Company.Employees.EmployeesProperties
{
    public class EmployeesSeniorityLevel : EmployeesProperty
    {
        private SeniorityLevels value;

        public EmployeesSeniorityLevel(SeniorityLevels seniorityLevel)
        {
            this.value = seniorityLevel;
        }

        public override T ReadPropertyValue<T>()
        {
            if (typeof(T) == typeof(SeniorityLevels))
            {
                return (T)(object)value;
            }
            else
            {
                throw new InvalidOperationException($"Cannot convert value from SeniorityLevels to {typeof(T)}");
            }
        }

        public override string ToString()
        {
            string stringValue = "";
            switch (value)
            {
                case SeniorityLevels.None:
                    stringValue = "-";
                    break;
                case SeniorityLevels.Junior:
                    stringValue = "Junior";
                    break;
                case SeniorityLevels.SemiSenior:
                    stringValue = "Semi Senior";
                    break;
                case SeniorityLevels.Senior:
                    stringValue = "Senior";
                    break;
                default:
                    break;
            };

            return stringValue;
        }
    }
}

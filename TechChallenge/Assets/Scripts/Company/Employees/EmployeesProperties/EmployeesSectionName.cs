using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.Employees;
using System;

namespace Company.Employees.EmployeesProperties
{
    public class EmployeesSectionName : EmployeesProperty
    {
        private string value;

        public EmployeesSectionName(string sectionName)
        {
            value = sectionName;
        }

        public override T ReadPropertyValue<T>()
        {
            if (typeof(T) == typeof(string))
            {
                return (T)(object)value;
            }
            else
            {
                throw new InvalidOperationException($"Cannot convert value from string to {typeof(T)}");
            }
        }

    }
}

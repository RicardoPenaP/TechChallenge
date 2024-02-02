using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Company.Interfaces;

namespace Company
{
    public class EmployeesAmount : IEmployeeProperty<int>
    {
        private int amount;

        public EmployeesAmount(int amount)
        {
            this.amount = amount;
        }

        public int GetPropertyValue()
        {
            return amount;
        }

    }
}

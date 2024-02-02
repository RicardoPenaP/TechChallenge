using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Company.Interfaces
{
    public interface IEmployeeProperty<T>
    {
        public T GetPropertyValue();
    }
}

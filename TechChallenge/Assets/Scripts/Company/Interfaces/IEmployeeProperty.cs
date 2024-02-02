using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Company
{
    public interface IEmployeeProperty<T>
    {
        public T GetPropertyValue();
    }
}

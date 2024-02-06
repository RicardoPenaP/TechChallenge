using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.Employees
{
    public class EmployeesInformation
    {
        private List<EmployeesProperty> employeesProperties;       

        public EmployeesInformation()
        {
            employeesProperties = new List<EmployeesProperty>();            
        }

        public void SetEmployeesPropeties(List<EmployeesProperty> employeesProperties)
        {
            this.employeesProperties = employeesProperties;
        }

        public void AddEmployeesProperty<T>(T newEmployeesProperty) where T : EmployeesProperty
        {
            if (!employeesProperties.Any(existingProperty => existingProperty.GetType() == typeof(T) || existingProperty.GetType().IsSubclassOf(typeof(T))))
            {
                employeesProperties.Add(newEmployeesProperty);
            }
            else
            {
                throw new InvalidOperationException($"A property of type {typeof(T)} already exists");
            }
        }

        public void OverrideEmployeesProperty<T>(T overridedProperty) where T : EmployeesProperty
        {
            if (employeesProperties.Any(existingProperty => existingProperty.GetType() == typeof(T) || existingProperty.GetType().IsSubclassOf(typeof(T))))
            {
                DeleteProperty(overridedProperty);                
            }            

            AddEmployeesProperty(overridedProperty);
        }

        public T GetEmployeesProperty<T>() where T : EmployeesProperty
        {
            return employeesProperties.OfType<T>().FirstOrDefault();
        }

        private void DeleteProperty<T>(T propertyToDelete)
        {
            var propertyToRemove = employeesProperties.FirstOrDefault(existingProperty => existingProperty.GetType() == typeof(T) || existingProperty.GetType().IsSubclassOf(typeof(T)));

            if (propertyToRemove != null)
            {
                employeesProperties.Remove(propertyToRemove);
            }
        }

        
    }
}

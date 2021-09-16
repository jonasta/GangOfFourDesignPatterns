﻿using System.Collections.Generic;

namespace Visitor
{
    public class Employees
    {
        private readonly List<Employee> _employees = new();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in _employees)
            {
                employee.Accept(visitor);
            }
        }
    }
}
﻿using System;

namespace EmployeeDirectoryNET20
{
    public class Employee
    {
       
        public string Name { get; set; }
        public int Salary { get; set; }


        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
         }
              
    }
}
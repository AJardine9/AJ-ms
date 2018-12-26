﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class Employee<T>
    {
        public static readonly People<Peep> Employees = new People<Peep>();

        public Employee()
        {
            Employees.Peoples.Add(new Peep(typeof(T).Name));// typeofTName is what we call a reflection, by looking into the assembly before the code is actually compiled 
        }
    }
}

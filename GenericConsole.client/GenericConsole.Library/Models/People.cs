using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConsole.Library.Models
{
    public class People<T> where T : APerson
    {
        public List<T> Peoples { get; set; }

        public People()
        {
            Peoples = new List<T>();
        }


        public class Employee<T>
        {
            public static readonly People<Peep> Clients = new People<Peep>();

            public List<T> Employees { get; set; }
        }
    }
}

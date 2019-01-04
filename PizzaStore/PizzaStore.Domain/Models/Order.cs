using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class Order
    {
        public Order (Location location)
        {

        }
        public bool activeacct;

        public bool Total(double val1)
        {
            if(val1 < 5000.00)
            {
                return true;
            }
            return false;
        }
    }
}

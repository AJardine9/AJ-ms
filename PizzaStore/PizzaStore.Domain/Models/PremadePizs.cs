using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{
    public class PremadePizs<T>
    {
        public static readonly Piz<Pizza> PremadePiz = new Piz<Pizza>();

        public PremadePizs()
        {
            PremadePiz.Pizs.Add(new Pizza(typeof(T).Name));
        }

       
          

        //public PremadePizs() => PremadePiz.Pizs.Add(new Pizza(List<T>.Name, 8.00, "crust"));
    }

}

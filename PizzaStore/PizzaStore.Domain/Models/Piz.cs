using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
    public class Piz<T> where T:APizza //Generic list of pizza where it has to be a pizza
    {
        public List<T> Pizs { get; set; }

        public Piz()
        {
            Pizs = new List<T>();
        }
    }
}
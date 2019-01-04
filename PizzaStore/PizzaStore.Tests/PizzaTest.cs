using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using PizzaStore.Domain.Models;

namespace PizzaStore.Tests
{
    public class PizzaTest
    {
        [Fact]
        public void Test_PizzaDefault()
        {
            var sut = new Pizza();

            Assert.True(sut.Toppings.Count == 3);
            Assert.NotNull(sut.Crust);
            Assert.True(sut.Size == PizzaSize.Medium);
            Assert.True(sut.Price > 0);
        }
        //Pizza Type 
        [Fact]
        public void Test_PepPizza()
        {
            var sut = new Pizza(); 

            var expected = "Pepperoni Cheese Pizza";

            var actual = sut.Pepperoni;

            Assert.IsType(expected.GetType(), actual);


        }
        [Fact]
        public void Test_CheesePizza()
        {
            var sut = new Pizza();

            var expected = "Cheese Pizza";
            var actual = sut.Cheese;

            Assert.IsType(expected.GetType(), actual);
        }


    // //Size 
    //    [Fact]
    //    public void Test_PizzaBasicSize()
    //    {
    //        var sut = new PizzaSize();

    //        var expected = "Basic";

    //        var actual = sut.BasicSize;

    //        Assert.IsType(expected.GetType(), actual);

    //    }

    //    [Fact]
    //    public void Test_PizzaExtraSize()
    //    {
    //        var sut = new PizzaSize();

    //        var expected = "Extra";

    //        var actual = sut.ExtraSize;

    //        Assert.IsType(expected.GetType(), actual);

    //    }


    //    //Price
    //    [Fact]
    //    public void Test_BasicPizzaPrice()
    //    {
    //        var sut = new BasicPizza();

    //        var expected = 8.00;

    //        var actual = sut.Price;

    //        Assert.Equal(expected, actual);
    //    }


    //    [Fact]
    //    public void Test_ExtraPizzaPrice()
    //    {
    //        var sut = new ExtraPizza();

    //        var expected = 12.00;

    //        var actual = sut.Price;
            
    //        Assert.Equal(expected, actual);
    //    }
    //}

}


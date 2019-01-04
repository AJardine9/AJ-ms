using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using pdm = PizzaStore.Domain.Models;


namespace PizzaStore.Tests
{
    public class OrderTest
    {

        //Test if an order can be made. Expected is true a order can be made, if the new order from a location belongs to an active account. 
        //Asserted True if the order belongs to an active account

        [Fact]
        public void Test_MakeOrder()
        {
            var sut = new Order(new Location("12702 Bruce B Downs St."));

            var expected = true;
            bool actual = sut.activeacct;

            Assert.True(expected == actual);
         

        }

        [Fact]
        public void Test_OrderTotal()//Testing if Order Total is less than $5000
        {
            var testOrder = new Order();
            var sut = testOrder.Total(400.00);

            Assert.True(sut == true);
        }


        [Fact]
        public void Test_
        [Fact(Skip = "please ignore")]
        public void OrderPerHour_Test()
        {
            var sut = new OrderTimeStamp();

            var expected = User.(sut());
        }

        [Fact]
        public void Test_AddToOrder()
        {
            var sut = new pdm.PremadePizs<pdm.Pepperoni>();

            Assert.NotNull(sut);

            
        }

            //TODO  make a datetime.now to be grabbed
            //TODO test to check inventory/availability
            //TODO test individual prices
            //TODO test Price total
            //TODO test total vaiable type
            //TODO test that 
    }
}

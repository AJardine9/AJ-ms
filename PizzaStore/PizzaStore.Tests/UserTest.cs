using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaStore.Tests
{
    public class UserTest
    {
        [Fact]
        public void Test_UserName()
        {
            var expected = "AJ Logging";
            var sut = new User(expected);

            Assert.IsType<string>(sut.Name);
            Assert.True(expected == sut.Name);
        }


        [Fact]
        public void UserAccount_Test()
        {
            var sut = new User();

            var expected = username is string;
            var actual = sut.Username;

            Assert.IsType(actual);

        }

        //TODo test if processed payed bool check if in list of order
        //TODO test if processed is true then cant cancel
        //TODO test if User has account
        //TODO test username is a string
        //TODO test password is not null
        //TODO that we can make a list of orders
        //TODO Test that we can add an order to the list
        //TODO test what time stamps for last order
        //TODO test that time is type date time 
        //ToDO  test that you can grab location
        //Todo test that you can submit order
        //Todo test that you can make an order 
    }
}

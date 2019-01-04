using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GenuinePiiz.test
{

 public class PizzTest
    {
        [Fact]
        public void UserAccount_Test()
        {
            var sut = new User();

            var expected = sut.ActiveAccount;
            var actual = sut.ActiveAccount;

            Assert.IsType(actual);
        }

        [Fact]
        public void OrderAmt_Test()
        {
            var sut = new Subtotal();

            var actual = sut.Total();

            Assert.InRange<actual, Minimum, Maximum>;
        }

        [Fact]
        public void OrderPerHour_Test()
        {
            var sut = new OrderTimeStamp();

            var expected = User.Subtotal()
        }

    }
}

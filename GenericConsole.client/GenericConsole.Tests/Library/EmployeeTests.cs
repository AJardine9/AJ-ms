using GenericConsole.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GenericConsole.Tests.Library
{
    public class EmployeeTests
    {
        [Fact]
        public void Test_PeepName()
        {
            var sut = new Peep();
            //var expected;
            var actual = sut.Name;

            Assert.IsType<string>(actual);
            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_PeepTitle()
        {
            var sut = new Peep();
            var actual = sut.Title;

            

            Assert.IsType<string>(actual);
            Assert.NotNull(actual);
        }
    }
}

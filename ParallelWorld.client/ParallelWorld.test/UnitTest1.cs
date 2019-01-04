using System;
using Xunit;

namespace ParallelWorld.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_ThreadMaster_Thread()
        {
            var sut +new ThreadModel();
            var expected = "fred";
            var actual = sut.ThreadMaster(expected);

            Assert.True(expected == actual);
        }
    }
}

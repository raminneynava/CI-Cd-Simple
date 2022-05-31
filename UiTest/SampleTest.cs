using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UiTest
{
    public class SampleTest
    {
        [Fact]
        public void Just_For_Run_Sample_Test()
        {
            var myvar = "test";
            bool result = (myvar == "test");
            Assert.True(result);
        }
    }
}

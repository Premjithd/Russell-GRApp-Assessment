using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class Test_LogicC
    {
        private List<Item> result;
        public Test_LogicC()
        {
            var app = new TestAssemblyTests();
            result = app.TestResult();
        }
        [Fact]
        public void Conjured_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(2, result.First(x => x.Name.Substring(0,9) == "Conjured ").SellIn);
        }

        [Fact]
        public void Conjured_Quality_ShouldDecreaseByTwoWhenSellinGreaterThanZero()
        {
            Assert.Equal(4, result.First(x => x.Name.Substring(0, 9) == "Conjured ").Quality);
        }
    }
}

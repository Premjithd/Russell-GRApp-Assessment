using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class Test_Default
    {
        private List<Item> result;
        public Test_Default()
        {
            var app = new TestAssemblyTests();
            result = app.TestResult();
        }

        [Fact]
        public void DexterityVest_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(9, result.First(x => x.Name == "+5 Dexterity Vest").SellIn);
        }

        [Fact]
        public void DexterityVest_Quality_ShouldDecreaseByOne()
        {
            Assert.Equal(19, result.First(x => x.Name == "+5 Dexterity Vest").Quality);
        }
    }
}

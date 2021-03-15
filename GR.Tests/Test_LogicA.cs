using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GR.Tests
{
    public class Test_LogicA
    {
        private List<Item> result;
        public Test_LogicA()
        {
            var app = new TestAssemblyTests();
            result = app.TestResult();
        }
        [Fact]
        public void AgedBrie_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(1, result.First(x => x.Name == "Aged Brie").SellIn);
        }

        [Fact]
        public void AgedBrie_Quality_ShouldDecreaseByOne()
        {
            Assert.Equal(2, result.First(x => x.Name == "Aged Brie").Quality);
        }
    }
}

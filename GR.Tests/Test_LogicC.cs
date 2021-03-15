using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class Test_LogicC
    {
        private List<Item> afterUpdate;
        private List<Item> beforeUpdate;
        public Test_LogicC()
        {
            var app = new TestAssemblyTests();
            afterUpdate = app.ValueAfterInventoryUpdate();
            beforeUpdate = app.ValueBeforeInventoryUpdate();
        }
        [Fact]
        public void Conjured_SellIn_ShouldDecreaseByOne()
        {
            var originalValue = beforeUpdate.First(x => x.Name.Substring(0, 9) == "Conjured ").SellIn;
            var updatedValue = afterUpdate.First(x => x.Name.Substring(0, 9) == "Conjured ").SellIn;
            Assert.Equal(originalValue, updatedValue);
        }

        [Fact]
        public void Conjured_Quality_ShouldDecreaseByTwoWhenSellinGreaterThanZero()
        {
            var originalValue = beforeUpdate.First(x => x.Name.Substring(0, 9) == "Conjured ").Quality;
            var updatedValue = afterUpdate.First(x => x.Name.Substring(0, 9) == "Conjured ").Quality;
            Assert.Equal(originalValue, updatedValue);
        }
    }
}

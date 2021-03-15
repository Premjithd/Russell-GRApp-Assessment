using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class Test_Default
    {
        private List<Item> afterUpdate;
        private List<Item> beforeUpdate;
        public Test_Default()
        {
            var app = new TestAssemblyTests();
            afterUpdate = app.ValueAfterInventoryUpdate();
            beforeUpdate = app.ValueBeforeInventoryUpdate();
        }

        [Fact]
        public void DexterityVest_SellIn_ShouldDecreaseByOne()
        {
            var originalValue = beforeUpdate.First(x => x.Name == "+5 Dexterity Vest").SellIn;
            var updatedValue = afterUpdate.First(x => x.Name == "+5 Dexterity Vest").SellIn;
            Assert.Equal(originalValue-1, updatedValue);
        }

        [Fact]
        public void DexterityVest_Quality_ShouldDecreaseByOne()
        {
            var originalValue = beforeUpdate.First(x => x.Name == "+5 Dexterity Vest").Quality;
            var updatedValue = afterUpdate.First(x => x.Name == "+5 Dexterity Vest").Quality;
            Assert.Equal(originalValue-1, updatedValue);
        }
    }
}

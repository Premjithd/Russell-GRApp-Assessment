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
        private List<Item> afterUpdate;
        private List<Item> beforeUpdate;
        public Test_LogicA()
        {
            var app = new TestAssemblyTests();
            afterUpdate = app.ValueAfterInventoryUpdate();
            beforeUpdate = app.ValueBeforeInventoryUpdate();
        }
        [Fact]
        public void AgedBrie_SellIn_ShouldDecreaseByOne()
        {
            var originalValue = beforeUpdate.First(x => x.Name == "Aged Brie").SellIn;
            var updatedValue = afterUpdate.First(x => x.Name == "Aged Brie").SellIn;
            Assert.Equal(originalValue -1, updatedValue);
        }

        [Fact]
        public void AgedBrie_Quality_ShouldIncreaseByOne()
        {
            var originalValue = beforeUpdate.First(x => x.Name == "Aged Brie").Quality;
            var updatedValue = afterUpdate.First(x => x.Name == "Aged Brie").Quality;
            Assert.Equal(originalValue + 1, updatedValue);
        }
    }
}

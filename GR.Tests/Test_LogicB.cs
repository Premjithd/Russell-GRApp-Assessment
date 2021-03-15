using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class Test_LogicB
    {
        private List<Item> afterUpdate;
        private List<Item> beforeUpdate;
        public Test_LogicB()
        {
            var app = new TestAssemblyTests();
            afterUpdate = app.ValueAfterInventoryUpdate();
            beforeUpdate = app.ValueBeforeInventoryUpdate();
        }
        [Fact]
        public void Backstagepasses_SellIn_ShouldDecreaseByOne()
        {
            var originalValue = beforeUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 0).First().SellIn;
            var updatedValue = afterUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 0).First().SellIn;
            Assert.Equal(originalValue - 1, updatedValue);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldIncreaseByOneWhenSellinGreaterThan10()
        {
            var originalValue = beforeUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 10).First().Quality;
            var updatedValue = afterUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 10).First().Quality;
            Assert.Equal(originalValue + 1, updatedValue);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldIncreaseByTwoWhenSellinBetween5And10()
        {
            var originalValue = beforeUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 5 && x.SellIn <=10).First().Quality;
            var updatedValue = afterUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 5 && x.SellIn <= 10).First().Quality;
            Assert.Equal(originalValue + 2, updatedValue);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldIncreaseByThreeWhenSellinBetween0And5()
        {
            var originalValue = beforeUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 0 && x.SellIn <= 5).First().Quality;
            var updatedValue = afterUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn > 0 && x.SellIn <= 5).First().Quality;
            Assert.Equal(originalValue + 3, updatedValue);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldBeZeroWhenSellinIsZero()
        {
            var originalValue = beforeUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn == 0 && x.Quality != 0).First().Name;
            var updatedValue = afterUpdate.Where(x => x.Name.Substring(0, 9) == "Backstage" &&  x.Name == originalValue).First().Quality;
            Assert.Equal(0, updatedValue);
        }
    }
}

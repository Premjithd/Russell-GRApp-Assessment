using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GR.Tests
{
    public class Test_LogicB
    {
        private List<Item> result;
        public Test_LogicB()
        {
            var app = new TestAssemblyTests();
            result = app.TestResult();
        }
        [Fact]
        public void Backstagepasses_SellIn_ShouldDecreaseByOne()
        {
            Assert.Equal(14, result.Where(x => x.Name.Substring(0,9) == "Backstage" && x.Quality == 21).First().SellIn);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldIncreaseByOneWhenSellinGT10()
        {
            Assert.Equal(21, result.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn == 14).First().Quality);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldIncreaseByTwoWhenSellinBetween5And10()
        {
            Assert.Equal(32, result.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn == 9).First().Quality);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldIncreaseByThreeWhenSellinBetween0And5()
        {
            Assert.Equal(36, result.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn == 4).First().Quality);
        }

        [Fact]
        public void Backstagepasses_Quality_ShouldBeZeroWhenSellinIsZero()
        {
            Assert.Equal(0, result.Where(x => x.Name.Substring(0, 9) == "Backstage" && x.SellIn == 0).First().Quality);
        }
    }
}

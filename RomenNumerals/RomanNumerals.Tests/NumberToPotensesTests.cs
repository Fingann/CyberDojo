using RomenNumerals;
using Xunit;

namespace RomanNumerals.Tests
{
    public class NumberToPotensesTests
    {
        [Fact]
        public void Should_return_8()
        {
            var potensArray = NumberToPotenses.GetPotenses(8);
            Assert.Equal(8,potensArray[0]);
        }
        
        [Fact]
        public void Should_return_10_as_first10Potens()
        {
            var potensArray = NumberToPotenses.GetPotenses(18);
            Assert.Equal(8,potensArray[0]);
            Assert.Equal(10,potensArray[1]);
        }
        
        [Fact]
        public void Should_return_potenses()
        {
            var potensArray = NumberToPotenses.GetPotenses(2587);
            Assert.Equal(7,potensArray[0]);
            Assert.Equal(80,potensArray[1]);
            Assert.Equal(500,potensArray[2]);
            Assert.Equal(2000,potensArray[3]);
        }
        
    }
}
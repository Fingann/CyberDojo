using System;
using RomenNumerals;
using Xunit;

namespace RomanNumerals.Tests
{
    public class RomanNumeralCreatorTests
    {
        [Fact]
        public void Number_1_should_return_I()
        {
            var romanNumeral = RomanNumeralCreator.Convert(1);
            Assert.Equal("I",romanNumeral);
        }
        [Fact]
        public void Number_2_should_return_II()
        {
            var romanNumeral = RomanNumeralCreator.Convert(2);
            Assert.Equal("II",romanNumeral);
        }
        
        [Fact]
        public void Number_6_should_return_VI()
        {
            var romanNumeral = RomanNumeralCreator.Convert(6);
            Assert.Equal("VI",romanNumeral);
        }
        
        [Fact]
        public void Number_1990_should_return_MCMXC()
        {
            var romanNumeral = RomanNumeralCreator.Convert(1990);
            Assert.Equal("MCMXC",romanNumeral);
        }
        
        [Fact]
        public void Number_2008_should_return_MMVIII()
        {
            var romanNumeral = RomanNumeralCreator.Convert(2008);
            Assert.Equal("MMVIII",romanNumeral);
        } 
        
        [Fact]
        public void Number_99_should_return_XCIX()
        {
            var romanNumeral = RomanNumeralCreator.Convert(99);
            Assert.Equal("XCIX",romanNumeral);
        }
        [Fact]
        public void Number_47_should_return_XLVII()
        {
            var romanNumeral = RomanNumeralCreator.Convert(47);
            Assert.Equal("XLVII",romanNumeral);
        }
    }
}
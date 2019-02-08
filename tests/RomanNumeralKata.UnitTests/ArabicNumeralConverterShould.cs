﻿using FluentAssertions;
using Xunit;

namespace RomanNumeralKata.UnitTests
{
    public class ArabicNumeralConverterShould
    {
        private ArabicNumeralConverter arabicNumeralCoverter;

        public ArabicNumeralConverterShould()
        {
            arabicNumeralCoverter = new ArabicNumeralConverter();
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        public void ConvertRomanNumeralToArabic(string romanNumber, int expected)
        {
            var actual = arabicNumeralCoverter.Convert(romanNumber);

            actual.Should().Be(expected);
        }
    }
}

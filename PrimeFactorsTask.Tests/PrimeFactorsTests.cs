using System;
using NUnit.Framework;

namespace PrimeFactorsTask.Tests
{
    public class PrimeFactorsTests
    {
        [TestCase(1, ExpectedResult = new int[] { })]
        [TestCase(2, ExpectedResult = new[] {2})]
        [TestCase(9, ExpectedResult = new[] {3, 3})]
        [TestCase(8, ExpectedResult = new[] {2, 2, 2})]
        [TestCase(12, ExpectedResult = new[] {2, 2, 3})]
        [TestCase(901255, ExpectedResult = new[] {5, 17, 23, 461})]
        [TestCase(93819012551, ExpectedResult = new[] {11, 9539, 894119})]
        public int[] GetFactors_Returns_Prime_Factors(long number)
        {
            return PrimeFactors.GetFactors(number);
        }

        [TestCase(-100)]
        [TestCase(-1)]
        [TestCase(0)]
        public static void GetFactors_Throw_ArgumentOutOfRangeException_If_Number_Less_Or_Equals_Zero(long number)
            => Assert.Throws<ArgumentOutOfRangeException>(() =>
                PrimeFactors.GetFactors(number), $"{number} cannot be less or equals zero.");
    }
}

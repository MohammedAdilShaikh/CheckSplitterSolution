using System;
using System.Collections.Generic;
using CheckSplitterLibrary;
using Xunit;

namespace CheckSplitterTests
{
    public class CheckSplitterTests
    {
        [Fact]
        public void SplitByNumberOfPeople_ReturnsCorrectAmount()
        {
            // Arrange
            var checkSplitter = new CheckSplitter();
            decimal amount = 100;
            int numberOfPeople = 5;

            // Act
            decimal result = checkSplitter.SplitByNumberOfPeople(amount, numberOfPeople);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void CalculateTipPerPerson_ReturnsCorrectTipAmountPerPerson()
        {
            // Arrange
            var checkSplitter = new CheckSplitter();
            var mealCosts = new Dictionary<string, decimal>
            {
                {"Alice", 25.50m},
                {"Bob", 30.75m},
                {"Charlie", 40.25m}
            };
            float tipPercentage = 15;

            // Act
            var result = checkSplitter.CalculateTipPerPerson(mealCosts, tipPercentage);

            // Assert
            Assert.Equal(0.04125m, result["Alice"], 4);
            Assert.Equal(0.0495m, result["Bob"], 4);
            Assert.Equal(0.065m, result["Charlie"], 4);
        }

        [Fact]
        public void CalculateTipPerPerson_ReturnsCorrectTipAmount()
        {
            // Arrange
            var checkSplitter = new CheckSplitter();
            decimal price = 100;
            int numberOfPatrons = 4;
            float tipPercentage = 20;

            // Act
            var result = checkSplitter.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            // Assert
            Assert.Equal(30, result);
        }
    }
}

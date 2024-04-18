using System;
using System.Collections.Generic;

namespace CheckSplitterLibrary
{
    public class CheckSplitter
    {
        public decimal SplitByNumberOfPeople(decimal amount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
                throw new ArgumentException("Number of people must be greater than zero.");

            return amount / numberOfPeople;
        }

        public Dictionary<string, decimal> CalculateTipPerPerson(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            var tipPerPerson = new Dictionary<string, decimal>();
            decimal totalCost = 0;

            foreach (var kvp in mealCosts)
            {
                totalCost += kvp.Value;
            }

            foreach (var kvp in mealCosts)
            {
                tipPerPerson[kvp.Key] = kvp.Value * (decimal)(tipPercentage / 100) / totalCost;
            }

            return tipPerPerson;
        }

        public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
        {
            if (numberOfPatrons <= 0)
                throw new ArgumentException("Number of patrons must be greater than zero.");

            decimal totalAmount = price * (1 + (decimal)(tipPercentage / 100));
            return totalAmount / numberOfPatrons;
        }
    }
}

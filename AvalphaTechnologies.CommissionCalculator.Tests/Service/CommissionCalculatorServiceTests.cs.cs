using System;
using Xunit;
using AvalphaTechnologies.CommissionCalculator.Model;
using AvalphaTechnologies.CommissionCalculator.Service;

namespace AvalphaTechnologies.CommissionCalculator.Tests.Service
{
    public class CommissionCalculatorServiceTests
    {

        private readonly CommissionCalculatorService _service;

        public CommissionCalculatorServiceTests()
        {
            _service = new CommissionCalculatorService();
        }

        [Fact]
        public void Calculate_ShouldReturnCorrectComission_WhenInputIsValid()
        {
            var request = new CommissionCalculationRequest
            {
                LocalSalesCount = 10,
                ForeignSalesCount = 10,
                AverageSaleAmount = 100
            };

            var result = _service.Calculate(request);

            Assert.Equal(550m, result.AvalphaTechnologiesCommissionAmount);
            Assert.Equal(95.5m, result.CompetitorCommissionAmount);

        }

        [Fact]
        public void Calculate_ShouldReturnZero_WhenSalesCountAreZero()
        {
            var request = new CommissionCalculationRequest
            {
                LocalSalesCount = 0,
                ForeignSalesCount = 0,
                AverageSaleAmount = 100
            };

            var result = _service.Calculate(request);

            Assert.Equal(0m, result.AvalphaTechnologiesCommissionAmount);
            Assert.Equal(0m, result.CompetitorCommissionAmount);


        }
    }
}

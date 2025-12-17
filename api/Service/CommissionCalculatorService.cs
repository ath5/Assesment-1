using AvalphaTechnologies.CommissionCalculator.Model;

namespace AvalphaTechnologies.CommissionCalculator.Service
{
    public class CommissionCalculatorService : ICommissionCalculatorService
    {

            private const decimal AvalphaLocalRate = 0.20m;
            private const decimal AvalphaForeignRate = 0.35m;

            private const decimal CompetitorLocalRate = 0.02m;
            private const decimal CompetitorForeignRate = 0.0755m;


        public CommissionCalculationResponse Calculate(CommissionCalculationRequest request)
        {
            var avalphaCommission =(request.LocalSalesCount * request.AverageSaleAmount * AvalphaLocalRate) +
                (request.ForeignSalesCount * request.AverageSaleAmount * AvalphaForeignRate);

            var competitorCommission = (request.LocalSalesCount * request.AverageSaleAmount * CompetitorLocalRate) +
                (request.ForeignSalesCount * request.AverageSaleAmount * CompetitorForeignRate);

            return new CommissionCalculationResponse
            {
                AvalphaTechnologiesCommissionAmount = avalphaCommission,
                CompetitorCommissionAmount = competitorCommission
            };
        }

    }
    
}

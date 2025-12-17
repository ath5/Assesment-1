using AvalphaTechnologies.CommissionCalculator.Model;

namespace AvalphaTechnologies.CommissionCalculator.Service
{
    public interface ICommissionCalculatorService
    {
        CommissionCalculationResponse Calculate(CommissionCalculationRequest request);

    }
}

using AvalphaTechnologies.CommissionCalculator.Model;
using AvalphaTechnologies.CommissionCalculator.Service;
using Microsoft.AspNetCore.Mvc;

namespace AvalphaTechnologies.CommissionCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommisionController : ControllerBase
    {

        private readonly ICommissionCalculatorService _commissionService;

        public CommisionController (ICommissionCalculatorService commissionService)
        {
            _commissionService = commissionService;

        }


        [HttpPost]
        [ProducesResponseType(typeof(CommissionCalculationResponse), 200)]
        [ProducesResponseType(400)]

        public IActionResult Calculate([FromBody] CommissionCalculationRequest request)
        {
            if (request.LocalSalesCount < 0 || request.ForeignSalesCount < 0)
            {
                return BadRequest("Sales counts must be zero or greater thean zero");
            }

            if (request.AverageSaleAmount < 0)
            {
                return BadRequest("Average sale amount must be zero or greater then zero");
            }

            if (request.LocalSalesCount > 1000000 || request.ForeignSalesCount > 1000000)
            {
                return BadRequest("Sales count exceeds the limit");
            }


            var result = _commissionService.Calculate(request);
            return Ok(result);
        }



    }

   
}

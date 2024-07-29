using Investment.Domain.Dtos;
using Investment.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Investment.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InvestmentController : ControllerBase
{
    private readonly ICalculateInvestmentUseCase _calculateInvestmentUseCase;

    public InvestmentController(ICalculateInvestmentUseCase calculateInvestmentUseCase)
        => _calculateInvestmentUseCase = calculateInvestmentUseCase;

    [HttpPatch]
    [ProducesResponseType(typeof(IActionResult), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public IActionResult CalculateInvestment([FromBody] InvestmentRequest request)
    {
        var result = _calculateInvestmentUseCase.CalculateInvestment(request);
        return Ok(result);
    }
}


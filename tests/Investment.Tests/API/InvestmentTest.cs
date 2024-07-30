using FluentAssertions;
using Investment.API.Controllers;
using Investment.Application.UseCases;
using Investment.Domain.Dtos;
using Investment.Domain.Interfaces;
using Investment.Tests.Fixtures;
using Moq;

namespace Investment.Tests.API;

[Collection(nameof(InvestmentTestFixture))]
public class InvestmentTest
{
    private readonly InvestmentTestFixture _fixture;
    private readonly InvestmentController _investmentController;
    private readonly Mock<ICalculateInvestmentUseCase> _calculateInvestmentUseCase = new();

    public InvestmentTest(InvestmentTestFixture fixture)
	{
        _fixture = fixture;
        _investmentController = new InvestmentController(_calculateInvestmentUseCase.Object);
    }

    [Fact(DisplayName = nameof(CalculeteInvestmentFinalValue))]
    [Trait("API", "Investment")]
    public void CalculeteInvestmentFinalValue()
    {
        var investmentTarget = _fixture.GetValidInvestment();
        var investmentResquest = new InvestmentRequest()
        {
            InitialValue = investmentTarget.InitialValue,
            PeriodInMonths = investmentTarget.PeriodInMonths
        };

        var result = _investmentController.CalculateInvestment(investmentResquest);

        result.Should().NotBeNull();
    }
}


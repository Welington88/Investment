using FluentAssertions;
using Investment.Application.UseCases;
using Investment.Domain.Dtos;
using Investment.Domain.Interfaces;
using Investment.Tests.Fixtures;
using Moq;

namespace Investment.Tests.Applicantion;

[Collection(nameof(InvestmentTestFixture))]
public class InvestmentTest
{
    private readonly InvestmentTestFixture _fixture;
    private ICalculateInvestmentUseCase CalculateInvestmentUseCase;
    private Mock<IInvestmentRepository> InvestmentRepositoryMoq = new();

    public InvestmentTest(InvestmentTestFixture fixture)
    {
       _fixture = fixture;
        InvestmentRepositoryMoq.Setup(i => i.GetCDI()).Returns(0.009);
        InvestmentRepositoryMoq.Setup(i => i.GetTB()).Returns(1.08);
        CalculateInvestmentUseCase = new CalculateInvestmentUseCase(InvestmentRepositoryMoq.Object);
    }

    [Fact(DisplayName = nameof(CalculeteInvestmentFinalValue))]
    [Trait("Application", "Investment")]
    public void CalculeteInvestmentFinalValue() {

        var investmentRequest = new InvestmentRequest()
        {
            InitialValue = 1000,
            PeriodInMonths = 3
        };


        var result = CalculateInvestmentUseCase.CalculateInvestment(investmentRequest);

        result.FinalValue.Should().Be(1019.53);
        result.NetValue.Should().Be(1015.14);
    }
}
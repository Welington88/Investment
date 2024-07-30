using FluentAssertions;
using Investment.Application.UseCases;
using Investment.Domain.Dtos;
using Investment.Domain.Interfaces;
using Investment.Infrastructure.Repositories;
using Investment.Tests.Fixtures;
using Moq;

namespace Investment.Tests.Applicantion;

[Collection(nameof(InvestmentTestFixture))]
public class InvestmentTest
{
    private readonly InvestmentTestFixture _fixture;
    private readonly ICalculateInvestmentUseCase _calculateInvestmentUseCase;
    private readonly Mock<IInvestmentRepository> _investmentRepositoryMoq = new();

    public InvestmentTest(InvestmentTestFixture fixture)
    {
        _fixture = fixture;
        _investmentRepositoryMoq.Setup(i => i.GetCDI()).Returns(0.009);
        _investmentRepositoryMoq.Setup(i => i.GetTB()).Returns(1.08);
        _calculateInvestmentUseCase = new CalculateInvestmentUseCase(_investmentRepositoryMoq.Object);
    }

    [Fact(DisplayName = nameof(CalculeteInvestmentFinalValue))]
    [Trait("Application", "Investment")]
    public void CalculeteInvestmentFinalValue() 
    {    
        var investmentTarget = _fixture.GetValidInvestment();
        var investmentResquest = new InvestmentRequest()
        {
            InitialValue = investmentTarget.InitialValue,
            PeriodInMonths = investmentTarget.PeriodInMonths
        };

        var result = _calculateInvestmentUseCase.CalculateInvestment(investmentResquest);

        result.FinalValue.Should().Be(investmentTarget.FinalValue);
        result.NetValue.Should().Be(investmentTarget.NetValue);
    }

    [Fact(DisplayName = nameof(CalculeteInvestmentFinalValue))]
    [Trait("Application", "Investment")]
    public void CalculeteInvestmentFinalValueLessEqualZero() 
    {    
        var investmentTarget = _fixture.GetValidInvestment();
        var invalidValue = _fixture.GetInvalidValue();
        var investmentResquest = new InvestmentRequest()
        {
            InitialValue = invalidValue,
            PeriodInMonths = investmentTarget.PeriodInMonths
        };

        Action action = () => _calculateInvestmentUseCase.CalculateInvestment(investmentResquest);
         
        action.Should().Throw<ArgumentException>()
        .WithMessage("Valor Inicial tem ser maior que zero");
    }

    [Fact(DisplayName = nameof(CalculeteInvestmentMonthLessEqualZero))]
    [Trait("Application", "Investment")]
    public void CalculeteInvestmentMonthLessEqualZero() 
    {    
        var investmentTarget = _fixture.GetValidInvestment();
        var invalidValue = _fixture.GetInvalidMonthValue();
        var investmentResquest = new InvestmentRequest()
        {
            InitialValue = investmentTarget.PeriodInMonths,
            PeriodInMonths = invalidValue
        };

        Action action = () => _calculateInvestmentUseCase.CalculateInvestment(investmentResquest);
         
        action.Should().Throw<ArgumentException>()
        .WithMessage("Valor Meses tem ser maior que zero");
    }

    [Theory(DisplayName = nameof(CalculeteInvestmentRepositoryCDITest))]
    [Trait("Repository", "Investment")]
    [InlineData(0.009)]
    public void CalculeteInvestmentRepositoryCDITest(double target)
    {
        var investmentRepository = new InvestmentRepository();

        var result = investmentRepository.GetCDI();

        (result <= 0).Should().BeFalse();
        (result > 0).Should().BeTrue();
        result.Should().Be(target);
    }

    [Theory(DisplayName = nameof(CalculeteInvestmentRepositoryTBTest))]
    [Trait("Repository", "Investment")]
    [InlineData(1.08)]
    public void CalculeteInvestmentRepositoryTBTest(double target)
    {
        var investmentRepository = new InvestmentRepository();


        var result = investmentRepository.GetTB();

        (result <= 0).Should().BeFalse();
        (result > 0).Should().BeTrue();
        result.Should().Be(target);
    }
}
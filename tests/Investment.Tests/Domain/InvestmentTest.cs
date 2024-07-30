using FluentAssertions;
using Investment.Domain.Dtos;
using Investment.Domain.Entities;
using Investment.Tests.Fixtures;

namespace Investment.Tests.Domain;

[Collection(nameof(InvestmentTestFixture))]
public class InvestmentTest
{
    private readonly InvestmentTestFixture _fixture;

    public InvestmentTest(InvestmentTestFixture fixture)
        => _fixture = fixture;

    [Fact(DisplayName = nameof(InstantiateInvestmentValue))]
    [Trait("Domain", "Investment")]
    public void InstantiateInvestmentValue()
    {
        var investmentTarget = _fixture.GetValidInvestment();
        var investmentValue = new InvestmentValue() {
            InitialValue = investmentTarget.InitialValue,
            PeriodInMonths = investmentTarget.PeriodInMonths,
            FinalValue = investmentTarget.FinalValue,
            NetValue = investmentTarget.NetValue
        };

        investmentValue.Should().NotBeNull();
        investmentValue.Should().BeEquivalentTo(investmentTarget);
    }

    [Fact(DisplayName = nameof(InstantiateInvestmentRequest))]
    [Trait("Domain", "Investment")]
    public void InstantiateInvestmentRequest()
    {
        var investmentTarget = _fixture.GetValidInvestment();
        var investmentValue = new InvestmentRequest()
        {
            InitialValue = investmentTarget.InitialValue,
            PeriodInMonths = investmentTarget.PeriodInMonths
        };

        investmentValue.Should().NotBeNull();
        investmentValue.InitialValue.Should().Be(investmentTarget.InitialValue);
        investmentValue.PeriodInMonths.Should().Be(investmentTarget.PeriodInMonths);
    }

    [Fact(DisplayName = nameof(InstantiateInvestmentResponse))]
    [Trait("Domain", "Investment")]
    public void InstantiateInvestmentResponse()
    {
        var investmentTarget = _fixture.GetValidInvestment();
        var investmentValue = new InvestmentResponse()
        {
            InitialValue = investmentTarget.InitialValue,
            PeriodInMonths = investmentTarget.PeriodInMonths,
            FinalValue = investmentTarget.FinalValue,
            NetValue = investmentTarget.NetValue
        };

        investmentValue.Should().NotBeNull();
        investmentValue.Should().BeEquivalentTo(investmentTarget);
    }
}



using Investment.Domain.Dtos;

namespace Investment.Domain.Interfaces;

public interface ICalculateInvestmentUseCase
{
    InvestmentResponse CalculateInvestment(InvestmentRequest investmentRequest);
}


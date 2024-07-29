using Investment.Domain.Interfaces;

namespace Investment.Infrastructure.Repositories;

public class InvestmentRepository : IInvestmentRepository
{
    private const double CDI = 0.009;
    private const double TB = 1.08;

    public double GetTB()
        => TB;

    public double GetCDI()
        => CDI;
}
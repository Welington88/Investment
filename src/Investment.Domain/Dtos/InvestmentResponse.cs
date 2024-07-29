namespace Investment.Domain.Dtos;

public class InvestmentResponse
{
    public double FinalValue { get; set; }
    public double NetValue { get; set; }
    public double InitialValue { get; set; }
    public int PeriodInMonths { get; set; }
}

namespace Investment.Domain.Entities;

public class InvestmentValue
{
    public double InitialValue { get; set; }
    public int PeriodInMonths { get; set; }
    public double FinalValue { get; set; }
    public double NetValue { get; set; }
}
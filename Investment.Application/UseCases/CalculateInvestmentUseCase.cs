﻿using Investment.Domain.Dtos;
using Investment.Domain.Entities;
using Investment.Domain.Interfaces;

namespace Investment.Application.UseCases;

public class CalculateInvestmentUseCase : ICalculateInvestmentUseCase
{
    private readonly IInvestmentRepository _investmentRepository;

    public CalculateInvestmentUseCase(IInvestmentRepository investmentService)
        => _investmentRepository = investmentService;
 

    public InvestmentResponse CalculateInvestment(InvestmentRequest investmentRequest)
    {
        var investmentValue = new InvestmentValue() {
            InitialValue = double.Parse(investmentRequest.InitialValue.ToString()),
            PeriodInMonths = investmentRequest.PeriodInMonths
        };

        CalculateInvestmentFutureValue(ref investmentValue);

        CalculateTax(ref investmentValue);
        

        return new InvestmentResponse
        {
            FinalValue = investmentValue.FinalValue,
            NetValue = investmentValue.NetValue
        };
    }

    private void CalculateInvestmentFutureValue(ref InvestmentValue investmentValue)
    {
        double CDI = _investmentRepository.GetCDI();
        double TB = _investmentRepository.GetTB();
        double finalValue = investmentValue.InitialValue;

        for (int i = 0; i < investmentValue.PeriodInMonths; i++)
        {
            finalValue *= (1 + (CDI * TB));
        }

        investmentValue.FinalValue = Math.Round(finalValue,2);
    }

    private void CalculateTax(ref InvestmentValue investmentValue)
    {
        double taxRate;
        double valueLiquid = investmentValue.FinalValue - investmentValue.InitialValue;
        int periodInMonths = investmentValue.PeriodInMonths;

        if (periodInMonths <= 6)
            taxRate = 0.225;
        else if (periodInMonths <= 12)
            taxRate = 0.20;
        else if (periodInMonths <= 24)
            taxRate = 0.175;
        else
            taxRate = 0.15;
        
        var discontValue = valueLiquid * taxRate;
        investmentValue.NetValue = Math.Round(investmentValue.FinalValue - discontValue, 2);
    }
}

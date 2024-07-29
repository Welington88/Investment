using Investment.Domain.Entities;
using Investment.Tests.Common;

namespace Investment.Tests.Fixtures;

public class InvestmentTestFixture : BaseFixture
{

    [CollectionDefinition(nameof(InvestmentTestFixture))]
    public class InvestmentTestFixtureCollection
        : ICollectionFixture<InvestmentTestFixture>
    { }

    public InvestmentTestFixture() : base() {}

    public InvestmentValue GetValidInvestment()
        => Faker.Random.ListItem(GetValidListInvestment());
    
    public double GetInvalidValue()
        => Faker.Random.Double(double.MinValue, 0);

    public int GetInvalidMonthValue()
        => Faker.Random.Int(int.MinValue, 0);
    

    public IList<InvestmentValue> GetValidListInvestment()
        => new List<InvestmentValue>(){
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 1,
                    FinalValue = 1009.72,
                    NetValue = 1007.53
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 2,
                    FinalValue = 1019.53,
                    NetValue = 1015.14
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 3,
                    FinalValue =  1029.44,
                    NetValue = 1022.82
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 4,
                    FinalValue = 1039.45,
                    NetValue = 1030.57
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 5,
                    FinalValue = 1049.55,
                    NetValue = 1038.40
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 6,
                    FinalValue = 1059.76,
                    NetValue = 1046.31
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 7,
                    FinalValue = 1070.06,
                    NetValue = 1056.05
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 8,
                    FinalValue = 1080.46,
                    NetValue = 1064.37
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 9,
                    FinalValue = 1090.96,
                    NetValue = 1072.77
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 10,
                    FinalValue = 1101.56,
                    NetValue = 1081.25
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 11,
                    FinalValue = 1112.27,
                    NetValue = 1089.82
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 12,
                    FinalValue = 1123.08,
                    NetValue = 1098.46
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 13,
                    FinalValue = 1134.00,
                    NetValue = 1110.55
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 14,
                    FinalValue = 1145.02,
                    NetValue = 1119.64
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 15,
                    FinalValue = 1156.15,
                    NetValue = 1128.82
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 16,
                    FinalValue = 1167.39,
                    NetValue = 1138.10
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 17,
                    FinalValue = 1178.74,
                    NetValue = 1147.46
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 18,
                    FinalValue = 1190.19,
                    NetValue = 1156.91
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 19,
                    FinalValue = 1201.76,
                    NetValue = 1166.45
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 20,
                    FinalValue = 1213.44,
                    NetValue = 1176.09
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 21,
                    FinalValue = 1225.24,
                    NetValue = 1185.82
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 22,
                    FinalValue = 1237.15,
                    NetValue = 1195.65
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 23,
                    FinalValue = 1249.17,
                    NetValue = 1205.57
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 24,
                    FinalValue = 1261.31,
                    NetValue = 1215.58
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 25,
                    FinalValue = 1273.57,
                    NetValue = 1232.53
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 26,
                    FinalValue = 1285.95,
                    NetValue = 1243.06
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 27,
                    FinalValue = 1298.45,
                    NetValue = 1253.68
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 28,
                    FinalValue = 1311.07,
                    NetValue = 1264.41
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 29,
                    FinalValue = 1323.82,
                    NetValue = 1275.25
                },
                new InvestmentValue()
                {
                    InitialValue = 1000,
                    PeriodInMonths = 30,
                    FinalValue = 1336.68,
                    NetValue = 1286.18
                }
        };
}


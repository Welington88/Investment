using Investment.Tests.Common;

namespace Investment.Tests.Fixtures;

public class InvestmentTestFixture : BaseFixture
{

    [CollectionDefinition(nameof(InvestmentTestFixture))]
    public class InvestmentTestFixtureCollection
        : ICollectionFixture<InvestmentTestFixture>
    { }


    public InvestmentTestFixture() : base() {}

    public string GetInvalidName()
    {
        return Faker.Random.String2(51);
    }
}


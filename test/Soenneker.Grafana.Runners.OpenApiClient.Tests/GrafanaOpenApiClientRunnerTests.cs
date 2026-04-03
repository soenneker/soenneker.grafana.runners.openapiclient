using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Grafana.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class GrafanaOpenApiClientRunnerTests : FixturedUnitTest
{
    public GrafanaOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

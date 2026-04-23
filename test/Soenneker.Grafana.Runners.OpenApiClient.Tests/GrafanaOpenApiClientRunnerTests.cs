using Soenneker.Tests.HostedUnit;

namespace Soenneker.Grafana.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GrafanaOpenApiClientRunnerTests : HostedUnitTest
{
    public GrafanaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

namespace AspireApp.Tests;

public class WebTests
{
    [Fact]
    public async Task GetWebResourceRootReturnsOkStatusCode()
    {
        // Arrange
        var appHost = await DistributedApplicationTestingBuilder
            .CreateAsync<Projects.AspireApp_AppHost>();

        appHost.Services.ConfigureHttpClientDefaults(clientBuilder =>
        {
            clientBuilder.AddStandardResilienceHandler();
        });

        await using var app = await appHost.BuildAsync();

        var resourceNotificationService = app.Services
            .GetRequiredService<ResourceNotificationService>();
        
        await app.StartAsync();

        // Act
        var httpClient = app.CreateHttpClient("webfrontend");

        await resourceNotificationService.WaitForResourceAsync(
                "webfrontend",
                KnownResourceStates.Running
            )
            .WaitAsync(TimeSpan.FromSeconds(30));
        
        var response = await httpClient.GetAsync("/");

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}

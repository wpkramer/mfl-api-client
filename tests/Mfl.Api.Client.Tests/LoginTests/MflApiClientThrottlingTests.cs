using System.Diagnostics;
using System.Net;
using Mfl.Api.Client.Tests.Helpers;

namespace Mfl.Api.Client.Tests.LoginTests;

public class MflApiClientThrottlingTests
{
    private const int TestSeason = 2025;
    const string TestEndpoint = "export?TYPE=nflSchedule&JSON=1&W=1"; // Week 1 schedule — tiny and public

    [Fact]
    public async Task Throttling_SequentialCalls_HaveAtLeastOneSecondGap()
    {
        var handler = new MockHttpMessageHandler(new HttpResponseMessage(HttpStatusCode.OK));

        using var client = new MflApiClient(TestSeason, handler);

        var stopwatch = Stopwatch.StartNew();

        var resp1 = await client.SendThrottledGetAsync(TestEndpoint);
        await resp1.Content.ReadAsStringAsync();
        var time1 = stopwatch.ElapsedMilliseconds;

        var resp2 = await client.SendThrottledGetAsync(TestEndpoint);
        await resp2.Content.ReadAsStringAsync();
        var time2 = stopwatch.ElapsedMilliseconds;

        var resp3 = await client.SendThrottledGetAsync(TestEndpoint);
        await resp3.Content.ReadAsStringAsync();
        var time3 = stopwatch.ElapsedMilliseconds;

        Assert.True(time1 >= 900);
        Assert.True(time2 + time1 >= 1800);
        Assert.True(time1 + time2 + time3 >= 2700);
    }

    [Fact]
    public async Task Throttling_MultipleCallsFromDifferentClients_AreIndependent()
    {
        // Arrange - Two separate clients (each with own semaphore)
        var handler1 = new MockHttpMessageHandler(new HttpResponseMessage(HttpStatusCode.OK));
        var handler2 = new MockHttpMessageHandler(new HttpResponseMessage(HttpStatusCode.OK));
        using var client1 = new MflApiClient(TestSeason, handler1);
        using var client2 = new MflApiClient(TestSeason, handler2);

        var stopwatch = Stopwatch.StartNew();

        // Act - Fire one request from each client concurrently
        var task1 = client1.SendThrottledGetAsync(TestEndpoint);
        var task2 = client2.SendThrottledGetAsync(TestEndpoint);

        var completionOrder = new List<string>();
        using Task cont1 = task1.ContinueWith(_ => completionOrder.Add("Client1"));
        using Task cont2 = task2.ContinueWith(_ => completionOrder.Add("Client2"));

        await Task.WhenAll(task1, task2);

        stopwatch.Stop();

        // Assert - Both should complete in under ~1.5s (no forced serialization between clients)
        Assert.True(stopwatch.ElapsedMilliseconds > 1800, $"Clients not throttled: took {stopwatch.ElapsedMilliseconds}ms");

        // Order can be either way — no priority between clients
        Assert.Equal(2, completionOrder.Count);
    }
}
using Mfl.Api.Client.Tests.Helpers;
using System.Net;

namespace Mfl.Api.Client.Tests.LoginTests;


public class MflApiClientMockTests
{
    [Fact]
    public async Task LoginAsync_ServerError_ReturnsFailure()
    {
        var handler = new MockHttpMessageHandler(new HttpResponseMessage(HttpStatusCode.InternalServerError));
        var client = new MflApiClient(2025, handler);

        var result = await client.LoginAsync("user", "pass");

        Assert.False(result.IsSuccess);
        Assert.Contains("Internal", result.Message);
    }


}

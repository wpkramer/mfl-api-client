using Xunit.Sdk;

namespace Mfl.Api.Client.Tests.LoginTests
{
    public class MflApiClientLoginTests
    {
        private const int TestSeason = 2025;
        private readonly string _username = Environment.GetEnvironmentVariable("MFL_TEST_USERNAME")
            ?? throw  SkipException.ForSkip("No username configured");
        private readonly string _password = Environment.GetEnvironmentVariable("MFL_TEST_PASSWORD")
            ?? throw SkipException.ForSkip("No password configured");

        [Fact]
        public async Task LoginAsync_ValidCredentials_ReturnsSuccess()
        {
            using var client = new MflApiClient(TestSeason);

            var result = await client.LoginAsync(_username, _password);

            Assert.True(result.IsSuccess, result.Message);
        }
    }
}
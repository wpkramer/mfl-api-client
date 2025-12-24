namespace Mfl.Api.Client.Tests.Helpers
{
    internal partial class MockHttpMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> responseFactory) : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, HttpResponseMessage> _responseFactory = responseFactory ?? throw new ArgumentNullException(nameof(responseFactory));

        public MockHttpMessageHandler(HttpResponseMessage response)
            : this(_ => response)
        {
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_responseFactory(request));
        }
    }
}

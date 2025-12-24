namespace Mfl.Api.Client.Tests.DeserializationTests;


public class MflLoginXmlTests
{


    [Theory]
    [InlineData("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n\r\n<error>Invalid Password</error>")]
    [InlineData(@"<?xml version=""1.0"" encoding=""utf-8""?><error status=""Invalid Username or Password"" />")]
    [InlineData(@"<?xml version=""1.0"" encoding=""utf-8""?><error>Invalid Password</error>")]
    [InlineData(@"<?xml version=""1.0"" encoding=""utf-8""?><error></error>")]
    [InlineData(@"<?xml version=""1.0"" encoding=""utf-8""?><response></response>")]
    [InlineData(@"<broken>not valid xml")]
    public async Task ParseInvalidPassword(string responseXml)
    {             
        var result = MflApiClient.ParseLogin(responseXml);
          
        Assert.False(result.IsSuccess, "Login should fail for invalid password.");
        Assert.True(string.IsNullOrEmpty(result.Value), "Value should be an empty string for invalid login.");
        Assert.True(null != result.Message, "Error message should not be null for invalid login.");
        Assert.True(result.Message.Length > 0, "Error message should be provided for invalid login.");
    }


    [Theory]
    [InlineData("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n\r\n<status MFL_USER_ID=\"dGVzdHVzzzzzzzzzz==\">OK</status>", "dGVzdHVzzzzzzzzzz==")]
    [InlineData(@"<?xml version=""1.0"" encoding=""utf-8""?> <status cookie_value=""abcABC123xyz==="" />", "abcABC123xyz===")]
    [InlineData(@"<?xml version=""1.0"" encoding=""utf-8""?><status MFL_USER_ID=""abcABCabcABC"">OK</status>", "abcABCabcABC")]
    [InlineData(@"<?xml version=""1.0"" encoding=""utf-8""?><status cookie_value=""cookieValue123"" MFL_USER_ID=""legacyValue456"" />", "cookieValue123")]
    public async Task ParseValidPassword(string responseXml, string expectedResult)
    {
        // Act
        var result = MflApiClient.ParseLogin(responseXml);
        // Assert
        Assert.True(result.IsSuccess, "ParseLogin failed");
        Assert.Equal(expectedResult,result.Value);
    }



    [Fact]
    public void Parse_InvalidResponse_NoCookieValue()
    {
        string responseXml = @"<?xml version=""1.0"" encoding=""utf-8""?>
                           <status>OK</status>";

        var result = MflApiClient.ParseLogin(responseXml);

        Assert.False(result.IsSuccess);
        //"              No cookie_value or MFL_USER_ID found in login response.
        Assert.Equal("No cookie_value or MFL_USER_ID found in login response.", result.Message);
    }

}

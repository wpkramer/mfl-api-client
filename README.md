# Mfl.Api.Client

A modern, async-friendly .NET client for the MyFantasyLeague (MFL) fantasy football API.

**Unofficial** — this is a community-maintained library, not affiliated with or endorsed by MyFantasyLeague.com.

## Features

- Full support for authentication (ApiKey or username/password login)
- Global rate limiting (1 request/second) to respect MFL guidelines
- Strongly-typed models for common exports (league, schedule, myleagues, ADP, players)
- Clean, testable design with dependency injection support
- Comprehensive unit tests

## Quick Start

```csharp
var client = new MflApiClient(2025);

// Preferred: Use your constant API key from the MFL Help page
client.ApiKey = "your-api-key";

// Or login with username/password
var loginResult = await client.LoginAsync("username", "password");
if (!loginResult.IsSuccess) throw new Exception(loginResult.Message);

// Fetch data
var leagueResult = await client.GetLeagueAsync("12345");
if (leagueResult.IsSuccess)
{
    Console.WriteLine(leagueResult.Value.Name);
}

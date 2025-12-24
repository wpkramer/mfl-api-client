using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mfl.Api.Common;

/// <summary>
/// Global rate limiter enforcing at least 1.05 seconds between MFL API requests.
/// </summary>
/// <remarks>
/// Ensures compliance with MFL's recommendation to space requests by at least one second.
/// Uses a semaphore to serialize access and a fixed delay for spacing.
/// </remarks>
public sealed class RateLimiter
{


    public static readonly RateLimiter Instance = new();

    private readonly SemaphoreSlim _semaphore = new(1, 1);
    private static readonly TimeSpan _delay = TimeSpan.FromMilliseconds(1050);

    private RateLimiter() { } // private to enforce singleton

    public async Task<T> ExecuteAsync<T>(Func<Task<T>> operation)
    {
        await _semaphore.WaitAsync();
        try
        {
            await Task.Delay(_delay);
            return await operation();
        }
        finally
        {
            _semaphore.Release();
        }
    }
}

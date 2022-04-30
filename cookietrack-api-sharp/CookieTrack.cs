using CookieTrackApiSharp.Models;
using CookieTrackApiSharp.Services;

namespace CookieTrackApiSharp
{
    public class CookieTrack
    {
        private readonly HttpClient _httpClient;
        private readonly CookieTrackService _cookieTrackService;
        
        public CookieTrack(HttpClient httpClient = null)
        {
            _httpClient = httpClient ?? new();

            _cookieTrackService = new CookieTrackService(_httpClient);
        }
        
        public async Task<Wallet?> GetBalancesAsync(string chain, string address) =>
            await _cookieTrackService.GetBalancesAsync(chain, address);

        public async Task<Project?> GetProjectBalancesAsync(string chain, string project, string address) =>
            await _cookieTrackService.GetProjectBalancesAsync(chain, project, address);

        public async Task<Transactions?> GetTransactionHistoryAsync(string chain, string address) =>
            await _cookieTrackService.GetTransactionHistoryAsync(chain, address);

        public async Task<Fees?> GetTransactionFeesAsync(string chain, string address) =>
            await _cookieTrackService.GetTransactionFeesAsync(chain, address);

        public async Task<Taxes?> GetTransactionHistoryWithTokenPricesAsync(string chain, string address) =>
            await _cookieTrackService.GetTransactionHistoryWithTokenPricesAsync(chain, address);

        public async Task<Routes?> GetRoutesAsync() =>
            await _cookieTrackService.GetRoutesAsync();

        public async Task<IEnumerable<TokenListItem>?> GetTokensAsync(string chain) =>
            await _cookieTrackService.GetTokensAsync(chain);
    }
}
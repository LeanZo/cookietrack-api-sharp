using CookieTrackApiSharp.Models;
using System.Net.Http.Json;

namespace CookieTrackApiSharp.Services
{
    public class CookieTrackService
    {
        private readonly HttpClient _httpClient;

        public CookieTrackService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.BaseAddress = new Uri("https://api.cookietrack.io/");
        }

        public async Task<Wallet?> GetBalancesAsync(string chain, string address) =>
            await _httpClient.GetFromJsonAsync<Wallet>(
                $"{chain}/wallet?address={address}");

        public async Task<Project?> GetProjectBalancesAsync(string chain, string project, string address) =>
            await _httpClient.GetFromJsonAsync<Project>(
                $"{chain}/{project}?address={address}");

        public async Task<Transactions?> GetTransactionHistoryAsync(string chain, string address) =>
            await _httpClient.GetFromJsonAsync<Transactions>(
                $"{chain}/txs?address={address}");

        public async Task<Fees?> GetTransactionFeesAsync(string chain, string address) =>
            await _httpClient.GetFromJsonAsync<Fees>(
                $"{chain}/fees?address={address}");
        
        public async Task<Taxes?> GetTransactionHistoryWithTokenPricesAsync(string chain, string address) =>
            await _httpClient.GetFromJsonAsync<Taxes>(
                $"{chain}/taxes?address={address}");

        public async Task<Routes?> GetRoutesAsync() =>
            await _httpClient.GetFromJsonAsync<Routes>(
                "routes");
        
        public async Task<IEnumerable<TokenListItem>?> GetTokensAsync(string chain) =>
            await _httpClient.GetFromJsonAsync<IEnumerable<TokenListItem>>(
                $"{chain}/tokens");
    }
}

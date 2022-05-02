[![NuGet](https://img.shields.io/nuget/v/CookieTrackApiSharp.svg)](https://www.nuget.org/packages/CookieTrackApiSharp)
# CookieTrackApiSharp
A simple [CookieTrack API](https://github.com/CookieTrack-io/cookietrack-api) wrapper for .NET

## Usage
The following is a snippet taken from the [example project](https://github.com/LeanZo/cookietrack-api-sharp/tree/main/CookieTrackApiSharp_Example)
   ```C#
   using CookieTrackApiSharp;

   var cookieTrack = new CookieTrack();

   var wallet = await cookieTrack.GetBalancesAsync("ethereum", "Insert Wallet Here");

   var project = await cookieTrack.GetProjectBalancesAsync("ethereum", "fees", "Insert Wallet Here");

   var transactions = await cookieTrack.GetTransactionHistoryAsync("ethereum", "Insert Wallet Here");

   var fees = await cookieTrack.GetTransactionFeesAsync("ethereum", "Insert Wallet Here");

   var taxes = await cookieTrack.GetTransactionHistoryWithTokenPricesAsync("ethereum", "Insert Wallet Here");

   var routes = await cookieTrack.GetRoutesAsync();

   var ethereumTokens = await cookieTrack.GetTokensAsync("ethereum");
   ```

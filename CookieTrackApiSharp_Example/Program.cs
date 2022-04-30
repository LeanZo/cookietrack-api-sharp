using CookieTrackApiSharp;

var cookieTrack = new CookieTrack();

var wallet = await cookieTrack.GetBalancesAsync("ethereum", "Insert Wallet Here");

var project = await cookieTrack.GetProjectBalancesAsync("ethereum", "fees", "Insert Wallet Here");

var transactions = await cookieTrack.GetTransactionHistoryAsync("ethereum", "Insert Wallet Here");

var fees = await cookieTrack.GetTransactionFeesAsync("ethereum", "Insert Wallet Here");

var taxes = await cookieTrack.GetTransactionHistoryWithTokenPricesAsync("ethereum", "Insert Wallet Here");

var routes = await cookieTrack.GetRoutesAsync();

var ethereumTokens = await cookieTrack.GetTokensAsync("ethereum");

Console.ReadLine();

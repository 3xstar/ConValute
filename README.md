# ConValute
Simple Windows Forms cryptocurrency tracker and converter.
# Description
Display real-time USD prices for 8 popular cryptocurrencies and convert amounts between them. Data fetched from CoinGecko API with auto-refresh.
# Features
• Real-time prices for BTC, ETH, SOL, XRP, SUI, AVAX, DOGE, OP • Auto-update every 60 seconds • Convert any supported crypto to another • Input validation and error handling • Clean WinForms UI with formatted output
# Requirements
• .NET 6.0 SDK or later • Windows (WinForms) • Internet connection
# Setup
Clone the repo.
Open solution in Visual Studio 2022 or Rider.
Restore NuGet packages (if any).
# Build & Run
• Build the solution and run from IDE (F5) or execute ConValute.exe from bin\Debug\net6.0-windows.
# Usage
Launch the application.
View live prices in the main window.
Enter amount → select "From" and "To" currencies → click Convert.
Result displays with 6 decimal precision.
# Notes
• CoinGecko free API has rate limits (~30 calls/min). If you see "429 Too Many Requests", wait 60 seconds.
• Prices are in USD. Conversion uses cross-rate calculation: amount * (price_from / price_to).
• To add more cryptocurrencies, update the API URL and CoinGeckoResponse DTO with new coin IDs.
# License
MIT — free for personal and commercial use.

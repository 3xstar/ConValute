# ConValute
Cryptocurrency tracker and converter for Windows. Displays real-time prices for 8 popular cryptocurrencies and converts between them.
# Features
📊 Real-time USD prices for: BTC, ETH, SOL, XRP, SUI, AVAX, DOGE, OP
🔁 Auto-update every 60 seconds via CoinGecko API
💱 Convert any supported crypto to another
⚠️ Input validation and error handling
🎯 Clean WinForms UI
# Requirements
Windows 10/11
.NET 6.0 or later
Internet connection
# Usage
Launch ConValute.exe
View live prices in the main window
Enter amount → select "From" and "To" currencies → click Convert
Result displays with 6 decimal precision
# API
Data source: CoinGecko API
Rate limit: Free tier (~30 calls/min)
No API key required
# Project Structure
ConValute/
├── Form1.cs          # Main UI and logic
├── CoinGeckoResponse.cs # JSON DTOs
├── HttpClient setup  # API requests with User-Agent
└── Timer handler     # 60s auto-refresh
# Build
Open in Visual Studio
File → Open → Project/Solution → ConValute.sln

Or via CLI
dotnet build ConValute.csproj
# License
MIT — free for personal and commercial use.

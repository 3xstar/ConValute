using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConValute
{
    public partial class Form1 : Form
    {
        // 📊 Переменные (свойства) для хранения курсов в USD
        public decimal BitcoinPrice { get; private set; }
        public decimal EthereumPrice { get; private set; }
        public decimal SolanaPrice { get; private set; }
        public decimal XrpPrice { get; private set; }
        public decimal SuiPrice { get; private set; }

        public decimal AvaxPrice { get; private set; }

        public decimal DogePrice { get; private set; }

        public decimal OpPrice { get; private set; }

        private readonly HttpClient _http = new HttpClient();
        private readonly string _apiUrl = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin,solana,ethereum,ripple,sui,avalanche-2,dogecoin,optimism&vs_currencies=usd";

        // Таймер для автообновления (каждые 5 секунд)
        private readonly System.Windows.Forms.Timer _refreshTimer = new System.Windows.Forms.Timer { Interval = 5_000 };

        public Form1()
        {
            InitializeComponent();

            // Создаем HttpClient с правильными заголовками
            _http = new HttpClient();
            _http.DefaultRequestHeaders.Add("User-Agent", "MyCryptoApp/1.0");
            _http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            Load += async (s, e) => await LoadRatesAsync();
        }

        private async Task LoadRatesAsync()
        {
            try
            {
                lblStatus.Text = "Загрузка курсов...";
                Application.DoEvents(); // Обновит UI перед запросом

                string json = await _http.GetStringAsync(_apiUrl);
                var response = JsonSerializer.Deserialize<CoinGeckoResponse>(json);

                if (response == null) throw new InvalidOperationException("Некорректный ответ API");

                // Записываем в переменные формы
                BitcoinPrice = response.Bitcoin.Usd;
                EthereumPrice = response.Ethereum.Usd;
                SolanaPrice = response.Solana.Usd;
                XrpPrice = response.Ripple.Usd;
                SuiPrice = response.Sui.Usd;
                AvaxPrice = response.Avax.Usd;
                DogePrice = response.Doge.Usd;
                OpPrice = response.Op.Usd;

                // Обновляем интерфейс
                lblBitcoin.Text = $"BTC: {BitcoinPrice:N2} $";
                lblEthereum.Text = $"ETH: {EthereumPrice:N2} $";
                lblSolana.Text = $"SOL: {SolanaPrice:N2} $";
                lblXrp.Text = $"XRP: {XrpPrice:N4} $"; // У XRP обычно много знаков после запятой
                lblSui.Text = $"SUI: {SuiPrice:N2} $";
                lblAvax.Text = $"AVAX: {AvaxPrice:N2} $";
                lblDoge.Text = $"DOGE: {DogePrice:N2} $";
                lblOp.Text = $"OP: {OpPrice:N2} $";

                lblStatus.Text = $"Обновлено: {DateTime.Now:HH:mm:ss}";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Ошибка: {ex.Message}";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _refreshTimer.Stop();
            _refreshTimer.Dispose();
            _http.Dispose();
            base.OnFormClosing(e);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbxConvert1 == null || tbxConvert2 == null || cbxValute1 == null || cbxValute2 == null)
            {
                lblError.Visible = true;
                lblError.Text = "Error: some value is empty";
            }
            else if (tbxConvert1 != null && tbxConvert2 != null && cbxValute1 != null && cbxValute2 != null)
            {
                lblError.Visible = false;
            }
        }
    }

    // 📦 DTO для десериализации JSON от CoinGecko
    public record CoinGeckoResponse(
        [property: JsonPropertyName("bitcoin")] CoinPrice Bitcoin,
        [property: JsonPropertyName("ethereum")] CoinPrice Ethereum,
        [property: JsonPropertyName("solana")] CoinPrice Solana,
        [property: JsonPropertyName("ripple")] CoinPrice Ripple,
        [property: JsonPropertyName("sui")] CoinPrice Sui,
        [property: JsonPropertyName("avalanche-2")] CoinPrice Avax,
        [property: JsonPropertyName("dogecoin")] CoinPrice Doge,
        [property: JsonPropertyName("optimism")] CoinPrice Op
    );

    public record CoinPrice([property: JsonPropertyName("usd")] decimal Usd);
}
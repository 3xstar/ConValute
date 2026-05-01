using System;
using System.Net.Http;
using System.Runtime.ExceptionServices;
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

        // Таймер для автообновления (каждые 60 секунд)
        private readonly System.Windows.Forms.Timer _refreshTimer = new System.Windows.Forms.Timer { Interval = 60_000 };

        static Dictionary<string, double> valutes = new Dictionary<string, double> { };

        public Form1()
        {
            InitializeComponent();

            cbxValute1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxValute2.DropDownStyle = ComboBoxStyle.DropDownList;
            // Создаем HttpClient с правильными заголовками
            _http = new HttpClient();
            _http.DefaultRequestHeaders.Add("User-Agent", "MyCryptoApp/1.0");
            _http.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            _refreshTimer.Tick += async (s, e) => await LoadRatesAsync();
            _refreshTimer.Start(); // ← ЭТО КЛЮЧЕВАЯ СТРОКА!

            Load += async (s, e) => await LoadRatesAsync();
        }

        private async Task LoadRatesAsync()
        {
            try
            {
                lblStatus.Text = "Downloading data...";
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

                string BitcoinSum = BitcoinPrice.ToString();
                if (double.TryParse(BitcoinSum, out double result))
                {
                    valutes["BITCOIN"] = result;
                }
                string SolanaSum = SolanaPrice.ToString();
                if (double.TryParse(SolanaSum, out double result2))
                {
                    valutes["SOLANA"] = result2;
                }
                string EthereumSum = EthereumPrice.ToString();
                if (double.TryParse(EthereumSum, out double result3))
                {
                    valutes["ETHEREUM"] = result3;
                }
                string XrpSum = XrpPrice.ToString();
                if (double.TryParse(XrpSum, out double result4))
                {
                    valutes["XRP"] = result4;
                }
                string SuiSum = SuiPrice.ToString();
                if (double.TryParse(SuiSum, out double result5))
                {
                    valutes["SUI"] = result5;
                }
                string AvaxSum = AvaxPrice.ToString();
                if (double.TryParse(AvaxSum, out double result6))
                {
                    valutes["AVAX"] = result6;
                }
                string DogeSum = DogePrice.ToString();
                if (double.TryParse(DogeSum, out double result7))
                {
                    valutes["DOGE"] = result7;
                }
                string OpSum = OpPrice.ToString();
                if (double.TryParse(OpSum, out double result8))
                {
                    valutes["OP"] = result8;
                }

                lblStatus.Text = $"Updated: {DateTime.Now:HH:mm:ss}";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
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
            if (string.IsNullOrEmpty(tbxConvertQuantity.Text) || string.IsNullOrEmpty(cbxValute1.Text) || string.IsNullOrEmpty(cbxValute2.Text))
            {
                lblError.Visible = true;
                lblError.Text = "Error: some value is empty";
                lblResult.Text = "";
                return;
            }

            lblError.Visible = false;
            string from_currency = cbxValute1.SelectedItem.ToString();
            string to_currency = cbxValute2.SelectedItem.ToString();

            if (!double.TryParse(tbxConvertQuantity.Text, out double result))
            {
                lblError.Visible = true;
                lblError.Text = "Error: invalid number of count";
                lblResult.Text = "";
                return;
            }

            if (valutes.TryGetValue(from_currency, out double from_sum) && valutes.TryGetValue(to_currency, out double to_sum))
            {
                if (result == 0 || result < 0)
                {
                    lblError.Visible = true;
                    lblError.Text = "Error: quantity cannot be zero or negative";
                    lblResult.Text = "";
                    return;
                }
                double converted = result * (from_sum / to_sum);
                lblResult.Text = $"{converted:N6}";
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Error: invalid currency";
                lblResult.Text = "";
                return;
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
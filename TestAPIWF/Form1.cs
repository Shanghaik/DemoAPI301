using Newtonsoft.Json;

namespace TestAPIWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_confirm_Click(object sender, EventArgs e)
        {
            // Lấy data từ form
            int money = Convert.ToInt32(tbt_money.Text);
            int day = Convert.ToInt32(tbt_day.Text);
            double percent = Convert.ToDouble(tbt_percent.Text);
            // Tạo URL request API
            string requestURL =
            $"https://localhost:7077/WeatherForecast/" +
            $"calculate-interest?day={day}&money={money}&percent={percent}";
            var httpClient = new HttpClient(); // Tại 1 httpClient để call API
            var response = await httpClient.GetAsync(requestURL); // Lấy kết quả
            // Đọc ra string Json
            string apiData = await response.Content.ReadAsStringAsync();
            // Lấy kết quả thu được bằng cách bóc dữ liệu Json
            string result = JsonConvert.DeserializeObject<string>(apiData);
            btn_result.Text = result;
        }
    }
}
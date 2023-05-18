// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
Console.OutputEncoding= System.Text.Encoding.UTF8;  
Console.WriteLine("Hello, World!");
Console.WriteLine("Nhập Số tiền bạn vay");
int money = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập Số ngày bạn nợ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Nhập tỉ lệ lãi khi vay của bạn");
double percent = Convert.ToDouble(Console.ReadLine());
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
Console.WriteLine("Bạn cần phải trả số tiền là: " + result);
Console.ReadKey();
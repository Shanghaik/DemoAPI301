using System.ComponentModel.DataAnnotations;

namespace AppView.Models
{
    public class TestValidate
    {
        /*
         * Trong Asp.Net core chúng ta có thể thực hiện
         * việc validate (check) dữ liệu thông qua DA trên
         * các model. Xử lý này nằm ở phía BE. CÓ thể thực
         * hiện được việc validate này với hầu hết các kiểu
         * dữ liệu nguyên thủy và string
         */
        [Required(ErrorMessage = "Phải nhập mã SV")] // Bắt buộc
        public string Id { get; set; }
        [StringLength(20)] // Giới hạn ko quá 20 kí tự
        public string Name { get; set; }
        [Required(ErrorMessage = "Phải nhập mô tả")]
        public string Description { get; set; }
        [Range(15, 50, ErrorMessage = "Tuổi không phù hợp")]
        public int Age { get; set; }
        [Range(1300000, int.MaxValue, 
            ErrorMessage = "Tài khoản bạn không đủ để ĐK học lại")]
        public int Balance { get; set; } // Số dư TK
        [RegularExpression("^(\\+\\d{1,2}\\s)?\\(?\\d{3}\\)?[\\s.-]\\d{3}[\\s.-]\\d{4}$",
            ErrorMessage = "Bạn cần nhập đúng SDT")]
        public string PhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Bạn nhập chưa đúng email")]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Blazor_from.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "使用者名稱是必要的！")]
        [StringLength(15, ErrorMessage = "名稱太長了啦，最多15個字元。")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "請輸入您的電子郵件。")]
        [EmailAddress(ErrorMessage = "這不是一個有效的電子郵件格式。")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "密碼不能為空。")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "密碼長度必須在 8 到 20 個字元之間。")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "請再次輸入密碼。")]
        [Compare(nameof(Password), ErrorMessage = "兩次輸入的密碼不一致！")]
        public string? ConfirmPassword { get; set; }
    }
}


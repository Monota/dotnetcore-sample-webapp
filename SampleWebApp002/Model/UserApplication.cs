using System.ComponentModel.DataAnnotations;

namespace SampleWebApp002.Model
{
    public class UserApplication
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "ユーザー名")]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "メールアドレス")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "パスワード")]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        [Display(Name = "パスワード(確認用)")]
        public string PasswordConfirm { get; set; }
    }
}
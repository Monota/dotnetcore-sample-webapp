using System.ComponentModel.DataAnnotations;

namespace SampleWebApp002.Model
{
    public class UserApplication
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "メールアドレス")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "パスワード")]
        public string Password { get; set; }
    }
}
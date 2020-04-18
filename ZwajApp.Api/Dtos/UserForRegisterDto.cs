using System.ComponentModel.DataAnnotations;

namespace ZwajApp.Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [StringLength(8,MinimumLength=4,ErrorMessage="يجب ادخال كلمة سر لاتزيد عن 8 احرف او تقل عن 4 احرف")]
        public string Password { get; set; }
    }
}
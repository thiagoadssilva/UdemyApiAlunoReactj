using System.ComponentModel.DataAnnotations;

namespace AlunosAPI.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatório")]
        [StringLength(20, ErrorMessage = " A {0} deve ter no mínimo {2} e no máximo {10}.", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

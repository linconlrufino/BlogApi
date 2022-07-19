using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models;

public class LoginViewModel
{

    [Required(ErrorMessage = "Informe o E-mail")]
    [EmailAddress(ErrorMessage = "O E-mail é inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe a Senha")]
    public string Password { get; set; }

}
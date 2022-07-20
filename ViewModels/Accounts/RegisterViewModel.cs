using System.ComponentModel.DataAnnotations;

namespace BlogApi.ViewModels.Accounts;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O Nome é obrigatório")]
    public string Name { get; set; }

    [Required(ErrorMessage = "O E-mail é obrigatório")]
    [EmailAddress(ErrorMessage = "O E-mail é inválido")]
    public string Email { get; set; }
}
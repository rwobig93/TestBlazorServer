using System.ComponentModel.DataAnnotations;

namespace Shared.Requests.Identity;

public class ResetPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    public string Password { get; set; } = null!;

    [Required]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;

    [Required]
    public string Token { get; set; } = null!;
}
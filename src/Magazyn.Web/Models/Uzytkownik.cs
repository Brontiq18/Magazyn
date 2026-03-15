using System.ComponentModel.DataAnnotations;

namespace Magazyn.Web.Models;

public class Uzytkownik
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Imie { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Nazwisko { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [MaxLength(200)]
    public string Email { get; set; } = string.Empty;
}

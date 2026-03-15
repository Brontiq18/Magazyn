using System.ComponentModel.DataAnnotations;

namespace Magazyn.Web.Models;

public class Ksiazka
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Tytul { get; set; } = string.Empty;

    [Required]
    [MaxLength(200)]
    public string Autor { get; set; } = string.Empty;

    [MaxLength(20)]
    public string? Isbn { get; set; }
}

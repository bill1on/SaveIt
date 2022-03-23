using System.ComponentModel.DataAnnotations;

namespace School.Models;

public class Gebruiker
{
    [Key] public int Id { get; set; }
    public int FamillieId { get; set; }
    public string Gebruikersnaam { get; set; }
    public string Email { get; set; }
    public string Wachtwoord { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace School.Models;

public class Famillie
{
    [Key] public int Id { get; set; }
    public String Naam { get; set; }
}
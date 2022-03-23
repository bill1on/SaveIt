using System.ComponentModel.DataAnnotations;

namespace School.Models;

public class Category
{
    [Key] public int Id { get; set; }
    public string Naam { get; set; }
    public int Bedrag { get; set; }
}
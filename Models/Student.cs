using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using SchoolAPI.Classes;
using System.Text.Json.Serialization;

namespace SchoolAPI.Models;

public class Student : Human
{
    [NotMapped]
    public const int MinimumAge = 6;

    [Required]
    public School? School { get; set; }

    [Required]
    public SchoolClass? Class { get; set; }

    [JsonIgnore]
    public ICollection<Grade>? Marks { get; set; }

    public Student()
    {
        Marks = new List<Grade>();
    }
}
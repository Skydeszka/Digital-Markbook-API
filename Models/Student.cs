using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using SchoolAPI.Classes;
using System.Text.Json.Serialization;

namespace SchoolAPI.Models;

public class Student : Human
{
    [Required]
    public School? School { get; set; }

    [Required]
    public SchoolClass? Class { get; set; }

    [JsonIgnore]
    public ICollection<Mark>? Marks { get; set; }

    public Student()
    {
        Marks = new List<Mark>();
    }
}
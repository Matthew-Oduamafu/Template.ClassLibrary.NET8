using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618

namespace Template.ClassLibrary.NET8.Data.Entities;

public class Employee : BaseEntity
{
    [Required] public string Name { get; set; }
    public DateTime Dob { get; set; }
    public DateTime HireDate { get; set; }
    public string JobTitle { get; set; }
    public double Salary { get; set; }
}
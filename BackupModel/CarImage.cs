using System.ComponentModel.DataAnnotations;

namespace BackendVE.Models;

public class CarImage
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "ImagePath cannot exceed 100 characters.")]
    public string? ImagePath { get; set; }

    public Car? Car { get; set; }
}
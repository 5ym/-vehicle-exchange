using System.ComponentModel.DataAnnotations;

namespace BackendVE.Models;

public class Car
{
    public int Id { get; set; }

    [Range(0, 49, ErrorMessage = "Maker must be between 0 and 50")]
    public int? Maker { get; set; }

    [StringLength(100, ErrorMessage = "Model cannot exceed 100 characters.")]
    public required string Model { get; set; }

    [Range(1769, 3000, ErrorMessage = "Year must be between 1769 and 3000")]
    public int? Year { get; set; }

    [Range(-1, 10000000, ErrorMessage = "Mileage must be between -1 and 10000000")]
    public int? Mileage { get; set; }

    [Range(0, 10000000000, ErrorMessage = "Price must be between 0 and 10000000000")]
    public required int Price { get; set; }

    [Range(0, 8, ErrorMessage = "Style must be between 0 and 20")]
    public int? Style { get; set; }

    [Range(0, 3, ErrorMessage = "DriveTrain must be between 0 and 10")]
    public int? DriveTrain { get; set; }

    [Range(0, 2, ErrorMessage = "DriverSide must be between 0 and 3")]
    public int? DriverSide { get; set; }

    [Range(1, 100000, ErrorMessage = "Displacement must be between 1 and 100000")]
    public int? Displacement { get; set; }

    [Range(0, 19, ErrorMessage = "ExteriorColor must be between 0 and 20")]
    public int? ExteriorColor { get; set; }

    [Range(0, 12, ErrorMessage = "InteriorColor must be between 0 and 20")]
    public int? InteriorColor { get; set; }

    [Range(0, 4, ErrorMessage = "Fuel must be between 0 and 100")]
    public int? Fuel { get; set; }

    [Range(0, 3, ErrorMessage = "Transmission must be between 0 and 100")]
    public int? Transmission { get; set; }

    [StringLength(2000, ErrorMessage = "Description cannot exceed 2000 characters.")]
    public string? Description { get; set; }

    [Range(0, 4, ErrorMessage = "Status must be between 0 and 4")]
    public required int Status { get; set; }

    public required User User { get; set; }

    public ICollection<CarImage>? CarImages { get; set; }
}
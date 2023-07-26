using System.ComponentModel.DataAnnotations;

namespace BackendVE.Models;

public class User
{
    public int Id { get; set; }

    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public required string Email { get; set; }

    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public required string Name { get; set; }

    [RegularExpression("^[0-9]{4}$", ErrorMessage = "Invalid Otp")]
    public string? Otp { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:u}")]
    public DateTime? OtpExp { get; set; }

    [Range(0, 3, ErrorMessage = "Status must be between 0 and 3")]
    public required int? Status { get; set; }


    public ICollection<Car>? Cars { get; set; }
}
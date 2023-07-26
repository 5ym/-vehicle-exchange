using System.ComponentModel.DataAnnotations;

namespace BackendVE.Models;

public class TokenInput
{
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public required string Email { get; set; }

    [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }
}
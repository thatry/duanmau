using System.ComponentModel.DataAnnotations;

public class User {  
    [Key]
    public int UserID { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }

    [Required]
    [MaxLength(100)]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    [MaxLength(20)]
    public string Role { get; set; }
}

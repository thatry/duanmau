using System.ComponentModel.DataAnnotations;

public class Admin
{
    [Key]
    public int AdminID { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }

    [Required]
    [MaxLength(100)]
    public string Password { get; set; }
}
